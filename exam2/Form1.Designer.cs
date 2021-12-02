
namespace exam2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberboxTempValue = new System.Windows.Forms.NumericUpDown();
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.imageTempGuage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGuage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Temperature:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(712, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(712, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberboxTempValue
            // 
            this.numberboxTempValue.AccessibleName = "numberboxTempValue";
            this.numberboxTempValue.Location = new System.Drawing.Point(412, 17);
            this.numberboxTempValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numberboxTempValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberboxTempValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numberboxTempValue.Name = "numberboxTempValue";
            this.numberboxTempValue.Size = new System.Drawing.Size(200, 26);
            this.numberboxTempValue.TabIndex = 3;
            this.numberboxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberboxTempValue.ValueChanged += new System.EventHandler(this.numberboxTempValue_ValueChanged);
            // 
            // comboUnits
            // 
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboUnits.Location = new System.Drawing.Point(653, 17);
            this.comboUnits.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(199, 26);
            this.comboUnits.TabIndex = 4;
            // 
            // imageTempGuage
            // 
            this.imageTempGuage.Image = ((System.Drawing.Image)(resources.GetObject("imageTempGuage.Image")));
            this.imageTempGuage.Location = new System.Drawing.Point(200, 109);
            this.imageTempGuage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.imageTempGuage.Name = "imageTempGuage";
            this.imageTempGuage.Size = new System.Drawing.Size(266, 68);
            this.imageTempGuage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageTempGuage.TabIndex = 5;
            this.imageTempGuage.TabStop = false;
            this.imageTempGuage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 623);
            this.Controls.Add(this.imageTempGuage);
            this.Controls.Add(this.comboUnits);
            this.Controls.Add(this.numberboxTempValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageTempGuage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberboxTempValue;
        private System.Windows.Forms.ComboBox comboUnits;
        private System.Windows.Forms.PictureBox imageTempGuage;
    }
}

