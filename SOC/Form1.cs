using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using Microsoft.Win32;

namespace SOC
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public enum Mode { soc, tenten };
    private Mode mode = Mode.soc;
    const string alphaSOC = "ABCDEFGHJKLMNPQRTUVWXY0123456789";
    const string alpha1010 = "ABCDEFGHJKMNPQRVWXY0123456789";
    string alpha { get { if (mode == Mode.soc) return alphaSOC; else return alpha1010; } }

    int alphalength { get { return alpha.Length; } }

    int checksumsize { get { if (mode == Mode.soc) return 128; else return alphalength; } }

    #region conversions
    private void ConvertToLatLong(string soc, out double lat, out double lon)
    {
      long soc_num = 0;

      for (int i = 0; i < soc.Length; i++)
      {
        soc_num *= alphalength;
        int x = alpha.IndexOf(soc[i]);
        soc_num += x;
      }

      long p = soc_num / checksumsize;
      int check = (int)(soc_num % checksumsize);

      lat = p / 3600000;
      lon = p - (lat * 3600000);

      lat = lat / 10000;
      lon = lon / 10000;

      lat -= 90;
      lon -= 180;

      int checksum = CalculateChecksum(p);

      if (check != checksum)
      {
        MessageBox.Show("Incorrect SOC");
        lat = 0;
        lon = 0;
      }
    }

    private string ConvertToSOC(double lat, double lon)
    {

      lat += 90;
      lon += 180;

      lat *= 10000;
      lon *= 10000;
      lat = Math.Floor(lat);
      lon = Math.Floor(lon);

      long p = Convert.ToInt64(lat * 3600000 + lon);

      long soc_num = p * checksumsize;

      int c = CalculateChecksum(p);

      soc_num += c;

      int digits = 10;

      // socnum = 689525963841905

      // soc = WWD5DCG2MU
      string soc = "";

      while (digits > 0)
      {
        int d = (int)(soc_num % alphalength);
        soc = alpha[d] + soc;
        soc_num = soc_num / alphalength;
        digits--;
      }
      if (soc_num != 0)
        throw new Exception("socnum != 0, entire value not encoded, something is wrong");

      return soc;
    }
    #endregion

    #region checksums
    private int CalculateChecksum(long p)
    {
      if (mode == Mode.soc)
        return CalculateSOCChecksum(p);
      if (mode == Mode.tenten)
        return Calculate1010Checksum(p);
      else
        throw new Exception();
    }

    private int CalculateSOCChecksum(long p)
    {
      int checksum = 0;
      int[] primes = new int[] { 2, 3, 5, 7, 11, 13, 17, 23, 29, 31, 37 };

      foreach (int prime in primes)
      {
        checksum += Convert.ToInt32((p % alphalength) * prime);
        p = p / alphalength;
      }

      checksum %= (checksumsize - 1);
      return checksum;
    }


    private int Calculate1010Checksum(long p)
    {
      int checksum = 0;
      for (int i = 1; i < 10; ++i)
      {
        checksum += (int)((p % alphalength) * i);
        p = p / alphalength;
      }
      checksum %= alphalength;

      return checksum;
    }
    #endregion

    #region button events

    private void btnConvertToSOC_Click(object sender, EventArgs e)
    {
      mode = Mode.soc;
      ConvertToSOC(tbSOC);
    }

    private void btnConvertTo1010_Click(object sender, EventArgs e)
    {
      mode = Mode.tenten;
      ConvertToSOC(tb1010);
    }

    private void btnConvertSOCToLatLong_Click(object sender, EventArgs e)
    {
      mode = Mode.soc;
      ConvertToLatLong(tbSOC);
    }

    private void btnConvert1010ToLatLong(object sender, EventArgs e)
    {
      mode = Mode.tenten;
      ConvertToLatLong(tb1010);
    }

    private void ConvertToLatLong(TextBox source)
    {
      double lat;
      double lon;
      ConvertToLatLong(source.Text.Trim(), out lat, out lon);
      tbTargetLat.Text = lat.ToString();
      tbTargetLong.Text = lon.ToString();
    }

    private double ParseDouble(string s)
    {
      // make sure any separator is replaced with the one that parse expects...
      s = s.Trim();
      s = s.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
      s = s.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
      return Double.Parse(s);
    }

    private void ConvertToSOC(TextBox target)
    {
      target.Text = ConvertToSOC(ParseDouble(tbSourceLat.Text), Double.Parse(tbSourceLong.Text.Replace('.', ',')));
    }
    #endregion

    #region URL support
    private static string GetDefaultBrowserPath()
    {
      string key = @"htmlfile\shell\open\command";
      RegistryKey registryKey =
      Registry.ClassesRoot.OpenSubKey(key, false);
      // get default browser path
      return ((string)registryKey.GetValue(null, null)).Split('"')[1];
    }

    private static void OpenURL(string url)
    {
      try
      {
        Process.Start(GetDefaultBrowserPath(), url);
      }
      catch (Exception exp)
      {
        MessageBox.Show(exp.Message);
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      OpenURL("http://blog.jgc.org/2010/06/1010-code.html");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      OpenURL("http://blog.jgc.org/2006/07/simple-code-for-entering-latitude-and.html");
    }
    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      OpenURL(string.Format("http://maps.google.com/maps?q={0},{1}", tbTargetLat.Text.Replace(",", "."), tbTargetLong.Text.Replace(",", ".")));
    }
  }
}
