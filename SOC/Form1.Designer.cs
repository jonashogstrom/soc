namespace SOC
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tbSourceLat = new System.Windows.Forms.TextBox();
      this.tbSourceLong = new System.Windows.Forms.TextBox();
      this.tbSOC = new System.Windows.Forms.TextBox();
      this.btnConvertToSOC = new System.Windows.Forms.Button();
      this.btnConvertSOC2LatLong = new System.Windows.Forms.Button();
      this.tbTargetLat = new System.Windows.Forms.TextBox();
      this.tbTargetLong = new System.Windows.Forms.TextBox();
      this.btnConvertTo1010 = new System.Windows.Forms.Button();
      this.tbConvert1010ToLatLong = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.tb1010 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tbSourceLat
      // 
      this.tbSourceLat.Location = new System.Drawing.Point(12, 24);
      this.tbSourceLat.Name = "tbSourceLat";
      this.tbSourceLat.Size = new System.Drawing.Size(100, 20);
      this.tbSourceLat.TabIndex = 0;
      this.tbSourceLat.Text = "51.09559";
      // 
      // tbSourceLong
      // 
      this.tbSourceLong.Location = new System.Drawing.Point(153, 24);
      this.tbSourceLong.Name = "tbSourceLong";
      this.tbSourceLong.Size = new System.Drawing.Size(100, 20);
      this.tbSourceLong.TabIndex = 1;
      this.tbSourceLong.Text = "1.12207 ";
      // 
      // tbSOC
      // 
      this.tbSOC.Location = new System.Drawing.Point(12, 109);
      this.tbSOC.Name = "tbSOC";
      this.tbSOC.Size = new System.Drawing.Size(100, 20);
      this.tbSOC.TabIndex = 2;
      // 
      // btnConvertToSOC
      // 
      this.btnConvertToSOC.Location = new System.Drawing.Point(12, 53);
      this.btnConvertToSOC.Name = "btnConvertToSOC";
      this.btnConvertToSOC.Size = new System.Drawing.Size(123, 23);
      this.btnConvertToSOC.TabIndex = 3;
      this.btnConvertToSOC.Text = "ConvertToSOC";
      this.btnConvertToSOC.UseVisualStyleBackColor = true;
      this.btnConvertToSOC.Click += new System.EventHandler(this.btnConvertToSOC_Click);
      // 
      // btnConvertSOC2LatLong
      // 
      this.btnConvertSOC2LatLong.Location = new System.Drawing.Point(12, 135);
      this.btnConvertSOC2LatLong.Name = "btnConvertSOC2LatLong";
      this.btnConvertSOC2LatLong.Size = new System.Drawing.Size(123, 23);
      this.btnConvertSOC2LatLong.TabIndex = 4;
      this.btnConvertSOC2LatLong.Text = "ConvertToLatLong";
      this.btnConvertSOC2LatLong.UseVisualStyleBackColor = true;
      this.btnConvertSOC2LatLong.Click += new System.EventHandler(this.btnConvertSOCToLatLong_Click);
      // 
      // tbTargetLat
      // 
      this.tbTargetLat.Location = new System.Drawing.Point(12, 193);
      this.tbTargetLat.Name = "tbTargetLat";
      this.tbTargetLat.Size = new System.Drawing.Size(100, 20);
      this.tbTargetLat.TabIndex = 6;
      // 
      // tbTargetLong
      // 
      this.tbTargetLong.Location = new System.Drawing.Point(153, 193);
      this.tbTargetLong.Name = "tbTargetLong";
      this.tbTargetLong.Size = new System.Drawing.Size(100, 20);
      this.tbTargetLong.TabIndex = 5;
      // 
      // btnConvertTo1010
      // 
      this.btnConvertTo1010.Location = new System.Drawing.Point(153, 50);
      this.btnConvertTo1010.Name = "btnConvertTo1010";
      this.btnConvertTo1010.Size = new System.Drawing.Size(119, 23);
      this.btnConvertTo1010.TabIndex = 7;
      this.btnConvertTo1010.Text = "ConvertTo1010";
      this.btnConvertTo1010.UseVisualStyleBackColor = true;
      this.btnConvertTo1010.Click += new System.EventHandler(this.btnConvertTo1010_Click);
      // 
      // tbConvert1010ToLatLong
      // 
      this.tbConvert1010ToLatLong.Location = new System.Drawing.Point(153, 135);
      this.tbConvert1010ToLatLong.Name = "tbConvert1010ToLatLong";
      this.tbConvert1010ToLatLong.Size = new System.Drawing.Size(119, 23);
      this.tbConvert1010ToLatLong.TabIndex = 8;
      this.tbConvert1010ToLatLong.Text = "ConvertToLatLong";
      this.tbConvert1010ToLatLong.UseVisualStyleBackColor = true;
      this.tbConvert1010ToLatLong.Click += new System.EventHandler(this.btnConvert1010ToLatLong);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "lat";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(150, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "long";
      // 
      // tb1010
      // 
      this.tb1010.Location = new System.Drawing.Point(153, 109);
      this.tb1010.Name = "tb1010";
      this.tb1010.Size = new System.Drawing.Size(100, 20);
      this.tb1010.TabIndex = 11;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "SOC";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(150, 90);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "10:10";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 177);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(18, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "lat";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(150, 177);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(27, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "long";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(8, 282);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(298, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Implementing an algorithm proposed by John Graham-Cunning";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(8, 295);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(87, 13);
      this.linkLabel1.TabIndex = 17;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "The 10:10 Code ";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new System.Drawing.Point(8, 308);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(148, 13);
      this.linkLabel2.TabIndex = 18;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "SOC: Simple Orientation Code";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 219);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(123, 23);
      this.button1.TabIndex = 19;
      this.button1.Text = "View in GoogleMap";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(307, 330);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tb1010);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbConvert1010ToLatLong);
      this.Controls.Add(this.btnConvertTo1010);
      this.Controls.Add(this.tbTargetLat);
      this.Controls.Add(this.tbTargetLong);
      this.Controls.Add(this.btnConvertSOC2LatLong);
      this.Controls.Add(this.btnConvertToSOC);
      this.Controls.Add(this.tbSOC);
      this.Controls.Add(this.tbSourceLong);
      this.Controls.Add(this.tbSourceLat);
      this.Name = "Form1";
      this.Text = "SOC / 10:10 converter";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbSourceLat;
    private System.Windows.Forms.TextBox tbSourceLong;
    private System.Windows.Forms.TextBox tbSOC;
    private System.Windows.Forms.Button btnConvertToSOC;
    private System.Windows.Forms.Button btnConvertSOC2LatLong;
    private System.Windows.Forms.TextBox tbTargetLat;
    private System.Windows.Forms.TextBox tbTargetLong;
    private System.Windows.Forms.Button btnConvertTo1010;
    private System.Windows.Forms.Button tbConvert1010ToLatLong;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tb1010;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.Button button1;
  }
}

