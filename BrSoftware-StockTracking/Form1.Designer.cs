
namespace BrSoftware_StockTracking
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx_Listed_Products_Amount = new System.Windows.Forms.TextBox();
            this.Tbx_Listed_Products_Price = new System.Windows.Forms.TextBox();
            this.Dgw_Products = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Search_Bar = new System.Windows.Forms.TextBox();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Follow_Salaries = new System.Windows.Forms.TextBox();
            this.denemebox = new System.Windows.Forms.TextBox();
            this.Tbx_Total_Amount_Selled_Products = new System.Windows.Forms.TextBox();
            this.Tbx_Total_Price_Selled_Products = new System.Windows.Forms.TextBox();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Products)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listelenen ürün sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listelenen ürün fiyatı";
            // 
            // Tbx_Listed_Products_Amount
            // 
            this.Tbx_Listed_Products_Amount.Enabled = false;
            this.Tbx_Listed_Products_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbx_Listed_Products_Amount.Location = new System.Drawing.Point(826, 5);
            this.Tbx_Listed_Products_Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Listed_Products_Amount.Name = "Tbx_Listed_Products_Amount";
            this.Tbx_Listed_Products_Amount.Size = new System.Drawing.Size(73, 22);
            this.Tbx_Listed_Products_Amount.TabIndex = 5;
            // 
            // Tbx_Listed_Products_Price
            // 
            this.Tbx_Listed_Products_Price.Enabled = false;
            this.Tbx_Listed_Products_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbx_Listed_Products_Price.Location = new System.Drawing.Point(826, 39);
            this.Tbx_Listed_Products_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Listed_Products_Price.Name = "Tbx_Listed_Products_Price";
            this.Tbx_Listed_Products_Price.Size = new System.Drawing.Size(73, 22);
            this.Tbx_Listed_Products_Price.TabIndex = 6;
            // 
            // Dgw_Products
            // 
            this.Dgw_Products.AllowUserToResizeColumns = false;
            this.Dgw_Products.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Dgw_Products.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgw_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgw_Products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgw_Products.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.Dgw_Products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgw_Products.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Dgw_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgw_Products.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgw_Products.Location = new System.Drawing.Point(3, 331);
            this.Dgw_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dgw_Products.Name = "Dgw_Products";
            this.Dgw_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgw_Products.Size = new System.Drawing.Size(1037, 249);
            this.Dgw_Products.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Arama";
            // 
            // Tbx_Search_Bar
            // 
            this.Tbx_Search_Bar.Location = new System.Drawing.Point(74, 299);
            this.Tbx_Search_Bar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Search_Bar.Name = "Tbx_Search_Bar";
            this.Tbx_Search_Bar.Size = new System.Drawing.Size(172, 24);
            this.Tbx_Search_Bar.TabIndex = 10;
            this.Tbx_Search_Bar.TextChanged += new System.EventHandler(this.Tbx_Search_Bar_TextChanged_1);
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.groupControl2);
            this.fluentDesignFormContainer1.Controls.Add(this.simpleButton6);
            this.fluentDesignFormContainer1.Controls.Add(this.separatorControl2);
            this.fluentDesignFormContainer1.Controls.Add(this.separatorControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.separatorControl4);
            this.fluentDesignFormContainer1.Controls.Add(this.groupControl1);
            this.fluentDesignFormContainer1.Controls.Add(this.simpleButton3);
            this.fluentDesignFormContainer1.Controls.Add(this.Tbx_Search_Bar);
            this.fluentDesignFormContainer1.Controls.Add(this.simpleButton2);
            this.fluentDesignFormContainer1.Controls.Add(this.simpleButton1);
            this.fluentDesignFormContainer1.Controls.Add(this.Dgw_Products);
            this.fluentDesignFormContainer1.Controls.Add(this.Tbx_Listed_Products_Price);
            this.fluentDesignFormContainer1.Controls.Add(this.label3);
            this.fluentDesignFormContainer1.Controls.Add(this.label2);
            this.fluentDesignFormContainer1.Controls.Add(this.label1);
            this.fluentDesignFormContainer1.Controls.Add(this.Tbx_Listed_Products_Amount);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(914, 626);
            this.fluentDesignFormContainer1.TabIndex = 22;
            this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.Follow_Salaries);
            this.groupControl2.Controls.Add(this.denemebox);
            this.groupControl2.Controls.Add(this.Tbx_Total_Amount_Selled_Products);
            this.groupControl2.Controls.Add(this.Tbx_Total_Price_Selled_Products);
            this.groupControl2.Controls.Add(this.simpleButton7);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(5, 500);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(894, 108);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "HESAP PANELİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(459, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "Bekleyen sipariş sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(404, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Satılan ürünlerin toplam alış fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Satılan ürünlerin stok adetleri toplamı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Satılan ürünlerin toplam fiyatı";
            // 
            // Follow_Salaries
            // 
            this.Follow_Salaries.Enabled = false;
            this.Follow_Salaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Follow_Salaries.Location = new System.Drawing.Point(615, 75);
            this.Follow_Salaries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Follow_Salaries.Name = "Follow_Salaries";
            this.Follow_Salaries.Size = new System.Drawing.Size(116, 22);
            this.Follow_Salaries.TabIndex = 39;
            // 
            // denemebox
            // 
            this.denemebox.Enabled = false;
            this.denemebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denemebox.Location = new System.Drawing.Point(615, 33);
            this.denemebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.denemebox.Name = "denemebox";
            this.denemebox.Size = new System.Drawing.Size(116, 22);
            this.denemebox.TabIndex = 38;
            // 
            // Tbx_Total_Amount_Selled_Products
            // 
            this.Tbx_Total_Amount_Selled_Products.Enabled = false;
            this.Tbx_Total_Amount_Selled_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbx_Total_Amount_Selled_Products.Location = new System.Drawing.Point(239, 79);
            this.Tbx_Total_Amount_Selled_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Total_Amount_Selled_Products.Name = "Tbx_Total_Amount_Selled_Products";
            this.Tbx_Total_Amount_Selled_Products.Size = new System.Drawing.Size(116, 22);
            this.Tbx_Total_Amount_Selled_Products.TabIndex = 37;
            // 
            // Tbx_Total_Price_Selled_Products
            // 
            this.Tbx_Total_Price_Selled_Products.Enabled = false;
            this.Tbx_Total_Price_Selled_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbx_Total_Price_Selled_Products.Location = new System.Drawing.Point(239, 33);
            this.Tbx_Total_Price_Selled_Products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_Total_Price_Selled_Products.Name = "Tbx_Total_Price_Selled_Products";
            this.Tbx_Total_Price_Selled_Products.Size = new System.Drawing.Size(116, 22);
            this.Tbx_Total_Price_Selled_Products.TabIndex = 36;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton7.ImageOptions.Image")));
            this.simpleButton7.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton7.Location = new System.Drawing.Point(777, 26);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(114, 72);
            this.simpleButton7.TabIndex = 35;
            this.simpleButton7.Text = "DÜKKANI KAPAT";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton6.Location = new System.Drawing.Point(943, 254);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(97, 69);
            this.simpleButton6.TabIndex = 22;
            this.simpleButton6.Text = "SATIŞ YAP";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl2.Location = new System.Drawing.Point(290, 81);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.separatorControl2.Size = new System.Drawing.Size(82, 22);
            this.separatorControl2.TabIndex = 32;
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl1.Location = new System.Drawing.Point(164, 81);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.separatorControl1.Size = new System.Drawing.Size(82, 22);
            this.separatorControl1.TabIndex = 31;
            // 
            // separatorControl4
            // 
            this.separatorControl4.LineAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.separatorControl4.Location = new System.Drawing.Point(30, 81);
            this.separatorControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.separatorControl4.Size = new System.Drawing.Size(82, 22);
            this.separatorControl4.TabIndex = 30;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.groupControl1.ButtonInterval = 3;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(5, 111);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(206, 103);
            this.groupControl1.TabIndex = 29;
            this.groupControl1.Text = "Takip formları";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton5.ImageOptions.SvgImage")));
            this.simpleButton5.Location = new System.Drawing.Point(76, 52);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(125, 44);
            this.simpleButton5.TabIndex = 21;
            this.simpleButton5.Text = "BORÇ TAKİP";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.Location = new System.Drawing.Point(280, 13);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 68);
            this.simpleButton3.TabIndex = 23;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(154, 13);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 68);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "ÜRÜN SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(16, 12);
            this.simpleButton1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(103, 69);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "ÜRÜN EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // Form1
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(914, 626);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form1.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Brs Software - Brstock Tracking 1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgw_Products)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Tbx_Listed_Products_Amount;
        public System.Windows.Forms.TextBox Tbx_Listed_Products_Price;
        public System.Windows.Forms.DataGridView Dgw_Products;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Tbx_Search_Bar;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Follow_Salaries;
        public System.Windows.Forms.TextBox denemebox;
        public System.Windows.Forms.TextBox Tbx_Total_Amount_Selled_Products;
        public System.Windows.Forms.TextBox Tbx_Total_Price_Selled_Products;
    }
}

