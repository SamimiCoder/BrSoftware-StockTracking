
namespace BrSoftware_StockTracking
{
    partial class Frm_Add_Debt_Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Debt_Out));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Out_Debt_Name = new System.Windows.Forms.TextBox();
            this.Tbx_Out_Debt_Price = new System.Windows.Forms.TextBox();
            this.dtp_Out_Debt_Date = new System.Windows.Forms.DateTimePicker();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsim Soyisim/Kurum Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borç Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Son ödeme tarihi";
            // 
            // Tbx_Out_Debt_Name
            // 
            this.Tbx_Out_Debt_Name.Location = new System.Drawing.Point(183, 78);
            this.Tbx_Out_Debt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Out_Debt_Name.Name = "Tbx_Out_Debt_Name";
            this.Tbx_Out_Debt_Name.Size = new System.Drawing.Size(233, 24);
            this.Tbx_Out_Debt_Name.TabIndex = 5;
            // 
            // Tbx_Out_Debt_Price
            // 
            this.Tbx_Out_Debt_Price.Location = new System.Drawing.Point(183, 146);
            this.Tbx_Out_Debt_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Out_Debt_Price.Name = "Tbx_Out_Debt_Price";
            this.Tbx_Out_Debt_Price.Size = new System.Drawing.Size(233, 24);
            this.Tbx_Out_Debt_Price.TabIndex = 6;
            // 
            // dtp_Out_Debt_Date
            // 
            this.dtp_Out_Debt_Date.Location = new System.Drawing.Point(183, 217);
            this.dtp_Out_Debt_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_Out_Debt_Date.Name = "dtp_Out_Debt_Date";
            this.dtp_Out_Debt_Date.Size = new System.Drawing.Size(233, 24);
            this.dtp_Out_Debt_Date.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(48, 293);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 63);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(310, 293);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(101, 63);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "SIFIRLA";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(183, 111);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.separatorControl1.Size = new System.Drawing.Size(233, 28);
            this.separatorControl1.TabIndex = 10;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(183, 181);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.separatorControl2.Size = new System.Drawing.Size(233, 28);
            this.separatorControl2.TabIndex = 11;
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(183, 251);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.separatorControl3.Size = new System.Drawing.Size(233, 28);
            this.separatorControl3.TabIndex = 12;
            // 
            // Frm_Add_Debt_Out
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 408);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dtp_Out_Debt_Date);
            this.Controls.Add(this.Tbx_Out_Debt_Price);
            this.Controls.Add(this.Tbx_Out_Debt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Frm_Add_Debt_Out.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Add_Debt_Out";
            this.Text = "Ödemeniz gereken borç bilgisi ekleyin";
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_Out_Debt_Name;
        private System.Windows.Forms.TextBox Tbx_Out_Debt_Price;
        private System.Windows.Forms.DateTimePicker dtp_Out_Debt_Date;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
    }
}