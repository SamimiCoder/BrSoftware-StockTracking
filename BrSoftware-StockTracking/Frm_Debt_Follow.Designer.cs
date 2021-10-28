
namespace BrSoftware_StockTracking
{
    partial class Frm_Debt_Follow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Debt_Follow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.tbx_Search2 = new System.Windows.Forms.TextBox();
            this.dgw_Debt_İn = new System.Windows.Forms.DataGridView();
            this.dgw_debt_Out = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_Toplam_Borc = new System.Windows.Forms.TextBox();
            this.Tbx_Toplam_Alınacak_Borc = new System.Windows.Forms.TextBox();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Debt_İn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_debt_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arama";
            // 
            // tbx_Search
            // 
            this.tbx_Search.Location = new System.Drawing.Point(49, 128);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(141, 22);
            this.tbx_Search.TabIndex = 8;
            this.tbx_Search.TextChanged += new System.EventHandler(this.tbx_Search_TextChanged_1);
            // 
            // tbx_Search2
            // 
            this.tbx_Search2.Location = new System.Drawing.Point(584, 128);
            this.tbx_Search2.Name = "tbx_Search2";
            this.tbx_Search2.Size = new System.Drawing.Size(141, 22);
            this.tbx_Search2.TabIndex = 9;
            this.tbx_Search2.TextChanged += new System.EventHandler(this.tbx_Search2_TextChanged_1);
            // 
            // dgw_Debt_İn
            // 
            this.dgw_Debt_İn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dgw_Debt_İn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Debt_İn.Location = new System.Drawing.Point(491, 151);
            this.dgw_Debt_İn.Name = "dgw_Debt_İn";
            this.dgw_Debt_İn.Size = new System.Drawing.Size(423, 402);
            this.dgw_Debt_İn.TabIndex = 10;
            // 
            // dgw_debt_Out
            // 
            this.dgw_debt_Out.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dgw_debt_Out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_debt_Out.Location = new System.Drawing.Point(8, 151);
            this.dgw_debt_Out.Name = "dgw_debt_Out";
            this.dgw_debt_Out.Size = new System.Drawing.Size(423, 402);
            this.dgw_debt_Out.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 587);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Borçlarınızın toplamı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alacağınız borçlar toplamı :";
            // 
            // Tbx_Toplam_Borc
            // 
            this.Tbx_Toplam_Borc.Enabled = false;
            this.Tbx_Toplam_Borc.Location = new System.Drawing.Point(130, 584);
            this.Tbx_Toplam_Borc.Name = "Tbx_Toplam_Borc";
            this.Tbx_Toplam_Borc.Size = new System.Drawing.Size(100, 22);
            this.Tbx_Toplam_Borc.TabIndex = 14;
            // 
            // Tbx_Toplam_Alınacak_Borc
            // 
            this.Tbx_Toplam_Alınacak_Borc.Enabled = false;
            this.Tbx_Toplam_Alınacak_Borc.Location = new System.Drawing.Point(810, 584);
            this.Tbx_Toplam_Alınacak_Borc.Name = "Tbx_Toplam_Alınacak_Borc";
            this.Tbx_Toplam_Alınacak_Borc.Size = new System.Drawing.Size(100, 22);
            this.Tbx_Toplam_Alınacak_Borc.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(4, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 56);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "BORÇ EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(107, 25);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 56);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "BORÇ SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton3.Location = new System.Drawing.Point(205, 25);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 56);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton4.Location = new System.Drawing.Point(345, 25);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 56);
            this.simpleButton4.TabIndex = 21;
            this.simpleButton4.Text = "GÜNCELLE";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton5.Location = new System.Drawing.Point(246, 25);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 56);
            this.simpleButton5.TabIndex = 20;
            this.simpleButton5.Text = "BORÇ SİL";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton6.Location = new System.Drawing.Point(142, 25);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 56);
            this.simpleButton6.TabIndex = 19;
            this.simpleButton6.Text = "BORÇ EKLE";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical;
            this.separatorControl1.Location = new System.Drawing.Point(448, 1);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(25, 622);
            this.separatorControl1.TabIndex = 22;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(8, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(423, 89);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "ÖDEMENİZ GEREKEN BORÇLAR";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton6);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(491, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(423, 81);
            this.groupControl2.TabIndex = 24;
            this.groupControl2.Text = "SİZE ÖDENECEK BORÇLAR";
            // 
            // Frm_Debt_Follow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 621);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.Tbx_Toplam_Alınacak_Borc);
            this.Controls.Add(this.Tbx_Toplam_Borc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgw_debt_Out);
            this.Controls.Add(this.dgw_Debt_İn);
            this.Controls.Add(this.tbx_Search2);
            this.Controls.Add(this.tbx_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Frm_Debt_Follow.IconOptions.LargeImage")));
            this.Name = "Frm_Debt_Follow";
            this.Text = "Brsoftware -BORÇ TAKİP PROGRAMI";
            this.Load += new System.EventHandler(this.Frm_Debt_Follow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Debt_İn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_debt_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbx_Search;
        public System.Windows.Forms.TextBox tbx_Search2;
        public System.Windows.Forms.DataGridView dgw_Debt_İn;
        public System.Windows.Forms.DataGridView dgw_debt_Out;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Tbx_Toplam_Borc;
        public System.Windows.Forms.TextBox Tbx_Toplam_Alınacak_Borc;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}