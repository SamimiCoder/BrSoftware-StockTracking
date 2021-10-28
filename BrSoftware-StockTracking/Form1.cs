using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrSoftware_StockTracking
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        BrstockContext context = new BrstockContext();
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        Product_Add_Form add_Form;
        string AdetGirisi = "0";

        private void Tbx_Search_Bar_TextChanged(object sender, EventArgs e)
        {
            
        }
        public int SatılanUrunAdedi;
        public double SatılanUrunFiyatı;
        public double SatilanUrunAlisFiyatToplami;
        public string paraBirimi = " TL";
        public string Adetİsmi = " Adet";

        public void UpdateSelledVariables()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            if (con.State == ConnectionState.Closed) 
            {
                con.Open();
            }
            SqlCommand sqlCommand = new SqlCommand("Select [satilan_urun_sayisi],[satilan_urunlerin_toplam_fiyati],[satilan_urunlerin_toplam_alis_fiyati] from SelledTable", con);
            SqlDataReader readerForSelledTable = sqlCommand.ExecuteReader();
            readerForSelledTable.Read();
            SatılanUrunAdedi = Int32.Parse(readerForSelledTable["satilan_urun_sayisi"].ToString());
            SatılanUrunFiyatı = Int32.Parse(readerForSelledTable["satilan_urunlerin_toplam_fiyati"].ToString());
            SatilanUrunAlisFiyatToplami = Int32.Parse(readerForSelledTable["satilan_urunlerin_toplam_alis_fiyati"].ToString());
            readerForSelledTable.Close();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

        public void DatagridSettings()
        {
            Dgw_Products.AllowUserToAddRows = false;
            Dgw_Products.Columns["Id"].HeaderText = "Urun ID";
            Dgw_Products.Columns["urun_ismi"].HeaderText = "Ürün İsmi";
            Dgw_Products.Columns["urun_kategori"].HeaderText = "Ürün Kategori Adı";
            Dgw_Products.Columns["urun_satıs_fiyat"].HeaderText = "Ürün Satış Fiyat";
            Dgw_Products.Columns["stok_miktarı"].HeaderText = "Stok Adedi";
            Dgw_Products.Columns["urun_alıs_fiyat"].HeaderText = "Ürün Alış Fiyatı";
            Dgw_Products.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            Dgw_Products.EnableHeadersVisualStyles = false;
            Dgw_Products.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(176, 196, 222);
            Dgw_Products.Columns["urun_kategori"].DefaultCellStyle.BackColor = Color.FromArgb(176, 196, 222);
            Dgw_Products.Columns["stok_miktarı"].DefaultCellStyle.BackColor = Color.FromArgb(176, 196, 222);
            Dgw_Products.Columns["urun_satıs_fiyat"].DefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250);
            Dgw_Products.Columns["urun_alıs_fiyat"].DefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250);
            Dgw_Products.Columns["urun_ismi"].DefaultCellStyle.BackColor = Color.FromArgb(245, 255, 250);
            Dgw_Products.DefaultCellStyle.Font = new Font("Unispace", 9);
            Dgw_Products.DefaultCellStyle.Padding = new Padding(2);
            Dgw_Products.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            


        }

        public void SendDataToGridView()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            da = new SqlDataAdapter("Select * from brstockTable", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "brstockTable");
            Dgw_Products.DataSource = ds.Tables[0];
            con.Close();
        }

        public void BottomPanelSettings()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select [satilan_urun_sayisi],[satilan_urunlerin_toplam_fiyati],[satilan_urunlerin_toplam_alis_fiyati] from [SelledTable]", con);

            SqlDataReader dr = cmd2.ExecuteReader();
            dr.Read();


            Tbx_Total_Amount_Selled_Products.Text = dr["satilan_urun_sayisi"].ToString() + " Adet ürün satıldı";
            Tbx_Total_Price_Selled_Products.Text = dr["satilan_urunlerin_toplam_fiyati"].ToString() + " TL";
            denemebox.Text = dr["satilan_urunlerin_toplam_alis_fiyati"].ToString() + " TL";

            dr.Close();
            con.Close();
        }

        public void GridUpdate()
        {
            try
            {

                da.Update(ds, "brstockTable");

                SendDataToGridView();//
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Yanlış Veri Girişi Yaptınız");
            }
        }



        public void SelledTableDataGet()
        {

            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Select [satilan_urun_sayisi],[satilan_urunlerin_toplam_fiyati],[satilan_urunlerin_toplam_alis_fiyati] from [SelledTable]", con);
            SqlDataReader reader = cmd2.ExecuteReader();
            Tbx_Total_Price_Selled_Products.Text = SatılanUrunFiyatı.ToString();
            Tbx_Total_Amount_Selled_Products.Text = SatılanUrunAdedi.ToString();
            denemebox.Text = SatilanUrunAlisFiyatToplami.ToString() + " Tl";
            reader.Read();
            denemebox.Text = reader["satilan_urunlerin_toplam_alis_fiyati"].ToString();
            Tbx_Listed_Products_Amount.Text = reader["satilan_urun_sayisi"].ToString();
            Tbx_Listed_Products_Price.Text = reader["satilan_urunlerin_toplam_fiyati"].ToString();
            reader.Close();
            try
            {
                string komut = "update brstockTable set stok_miktarı=@stok_miktarı where Id=@Id";
                SqlCommand command = new SqlCommand(komut, con);
                command.Parameters.AddWithValue("@stok_miktarı", Dgw_Products.CurrentRow.Cells["stok_miktarı"].Value);
                command.Parameters.AddWithValue("@Id", Dgw_Products.CurrentRow.Cells["Id"].Value);
                command.ExecuteNonQuery();

            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Tablo Boş");
            }


            SatılanUrunAdedi += Int32.Parse(AdetGirisi);
            SatılanUrunFiyatı += Int32.Parse(Dgw_Products.CurrentRow.Cells[3].Value.ToString()) * Int32.Parse(AdetGirisi);
            SatilanUrunAlisFiyatToplami += Int32.Parse(Dgw_Products.CurrentRow.Cells[5].Value.ToString()) * Int32.Parse(AdetGirisi);

            Tbx_Total_Price_Selled_Products.Text = SatılanUrunFiyatı.ToString();
            Tbx_Total_Amount_Selled_Products.Text = SatılanUrunAdedi.ToString();
            denemebox.Text = SatilanUrunAlisFiyatToplami.ToString();


            //reader.Close();
            con.Close();
        }


       

        private void Form1_Load(object sender, EventArgs e)
        {
            BottomPanelSettings();
            UpdateSelledVariables();
            SendDataToGridView();
            SelledTableDataGet();
            int gridviewDataSayısı = Dgw_Products.RowCount - 1;
            DatagridSettings();

            context.CalculateListedProductsPrice(Dgw_Products, Tbx_Listed_Products_Price);
            context.CalculateListedProductsAmount(Dgw_Products, Tbx_Listed_Products_Amount);
            //CalculateSelledProducts_And_List();
        }

        private void Btn_Open_debt_follow_Frm_Click_1(object sender, EventArgs e)
        {
            
        }

        

        private void Btn_Sell_Product_Click_1(object sender, EventArgs e)
        {
            AdetGirisi = Interaction.InputBox("Satılacak Ürün Adedi", "Kaç Adet ?");
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter da2 = new SqlDataAdapter("select * from [SelledTable]", con);
            cmdb = new SqlCommandBuilder(da);
            da2.Fill(ds, " [SelledTable]");
            Dgw_Products.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            if (AdetGirisi.Equals("0"))
            {
                MessageBox.Show("SATIŞI YAPILACAK ÜRÜN SAYISI 0'DAN BÜYÜK OLMALIDIR LÜTFEN TEKRAR DENEYİN", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdetGirisi.Equals("") || AdetGirisi.Equals(" "))
            {
                MessageBox.Show("Veri Giriş Kısmı Boş Bırakılamaz", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                Dgw_Products.CurrentRow.Cells[4].Value = Int32.Parse(Dgw_Products.CurrentRow.Cells[4].Value.ToString()) - Int32.Parse(AdetGirisi);
                if (Int32.Parse(Dgw_Products.CurrentRow.Cells[4].Value.ToString()) <= -1 && Int32.Parse(AdetGirisi) > Int32.Parse(Dgw_Products.CurrentRow.Cells[4].Value.ToString()))
                {
                    DialogResult dialog = MessageBox.Show("Bu ürünün stoğu kalmadı.", "STOĞU OLMAYAN ÜRÜN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendDataToGridView();
                }
                else
                {
                    context.CalculateListedProductsPrice(Dgw_Products, Tbx_Listed_Products_Price);
                    context.CalculateListedProductsAmount(Dgw_Products, Tbx_Listed_Products_Amount);
                    SelledTableDataGet();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //textboxlara yansıtılması, ve komutlar
                    SqlCommand datacommand2 = new SqlCommand("UPDATE SelledTable set satilan_urun_sayisi=@satilan_urun_sayisi, satilan_urunlerin_toplam_fiyati=@satilan_urunlerin_toplam_fiyati,satilan_urunlerin_toplam_alis_fiyati=@satilan_urunlerin_toplam_alis_fiyati", con);
                    datacommand2.Parameters.AddWithValue("@satilan_urun_sayisi", Tbx_Total_Amount_Selled_Products.Text);
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_fiyati", Tbx_Total_Price_Selled_Products.Text);
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_alis_fiyati", denemebox.Text);
                    datacommand2.ExecuteNonQuery();
                    context.CalculateListedProductsPrice(Dgw_Products, Tbx_Listed_Products_Price);
                    context.CalculateListedProductsAmount(Dgw_Products, Tbx_Listed_Products_Amount);




                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void Btn_Close_Place_Click_1(object sender, EventArgs e)
        {
            con.Open();
            DialogResult KapanisKontrolu = 0;
            try
            {
                double karMarjı = (Double.Parse(Tbx_Total_Price_Selled_Products.Text) - Double.Parse(denemebox.Text));

                KapanisKontrolu = MessageBox.Show("Bu gün için kârınız :" + karMarjı.ToString(), " Gün içinde yapmış olduğunuz kâr", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (System.FormatException)
            {
                DialogResult satisYapilmadıKutusu = MessageBox.Show("Bu gün hiç satış yapılmadı");
                if (satisYapilmadıKutusu == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }

            }
            finally
            {
                if (KapanisKontrolu == DialogResult.OK || con.State == ConnectionState.Closed)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand datacommand2 = new SqlCommand("UPDATE SelledTable set satilan_urun_sayisi=@satilan_urun_sayisi, satilan_urunlerin_toplam_fiyati=@satilan_urunlerin_toplam_fiyati,satilan_urunlerin_toplam_alis_fiyati=@satilan_urunlerin_toplam_alis_fiyati", con);
                    datacommand2.Parameters.AddWithValue("@satilan_urun_sayisi", "");
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_fiyati", "");
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_alis_fiyati", "");
                    Tbx_Total_Amount_Selled_Products.Text = "";
                    Tbx_Total_Price_Selled_Products.Text = "";
                    denemebox.Text = "";
                    datacommand2.ExecuteNonQuery();
                    this.Close();
                    Application.Exit();

                }
                else if (KapanisKontrolu == DialogResult.Cancel)
                {
                    MessageBox.Show("Kapanış iptal edildi");

                }
                con.Close();
            }
        }

        

        

        

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            add_Form = new Product_Add_Form();
            add_Form.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            GridUpdate(); ds.AcceptChanges();
            MessageBox.Show("Kayıt güncellendi");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in Dgw_Products.Rows)
            {
                int Id = Convert.ToInt32(drow.Cells[0].Value);
                context.SatırSil(Id);
                SendDataToGridView();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Siparis_Formu siparis_Formu = new Siparis_Formu();
            siparis_Formu.Show();
        }

        

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Frm_Debt_Follow _Debt_Follow = new Frm_Debt_Follow();
            _Debt_Follow.Show();
        }

        private void Tbx_Search_Bar_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[0];
            DataView dataView = dt.DefaultView;
            dataView.RowFilter = String.Format("urun_ismi LIKE '" + Tbx_Search_Bar.Text + "%'");
            Dgw_Products.DataSource = dataView;
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            AdetGirisi = XtraInputBox.Show("Satılacak Ürün Adedi", "Kaç Adet ?","Adet Miktarı.");
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter da2 = new SqlDataAdapter("select * from [SelledTable]", con);
            cmdb = new SqlCommandBuilder(da);
            da2.Fill(ds, " [SelledTable]");
            Dgw_Products.DataSource = ds.Tables[0];
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            if (AdetGirisi.Equals("0"))
            {
                MessageBox.Show("SATIŞI YAPILACAK ÜRÜN SAYISI 0'DAN BÜYÜK OLMALIDIR LÜTFEN TEKRAR DENEYİN", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (AdetGirisi.Equals("") || AdetGirisi.Equals(" "))
            {
                MessageBox.Show("Veri Giriş Kısmı Boş Bırakılamaz", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                Dgw_Products.CurrentRow.Cells[4].Value = Int32.Parse(Dgw_Products.CurrentRow.Cells[4].Value.ToString()) - Int32.Parse(AdetGirisi);
                if (Int32.Parse(Dgw_Products.CurrentRow.Cells[4].Value.ToString()) <= -1 && Int32.Parse(AdetGirisi) > Int32.Parse(Dgw_Products.CurrentRow.Cells[4].Value.ToString()))
                {
                    DialogResult dialog = MessageBox.Show("Bu ürünün stoğu kalmadı.", "STOĞU OLMAYAN ÜRÜN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SendDataToGridView();
                }
                else
                {
                    context.CalculateListedProductsPrice(Dgw_Products, Tbx_Listed_Products_Price);
                    context.CalculateListedProductsAmount(Dgw_Products, Tbx_Listed_Products_Amount);
                    SelledTableDataGet();
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    //textboxlara yansıtılması, ve komutlar
                    SqlCommand datacommand2 = new SqlCommand("UPDATE SelledTable set satilan_urun_sayisi=@satilan_urun_sayisi, satilan_urunlerin_toplam_fiyati=@satilan_urunlerin_toplam_fiyati,satilan_urunlerin_toplam_alis_fiyati=@satilan_urunlerin_toplam_alis_fiyati", con);
                    datacommand2.Parameters.AddWithValue("@satilan_urun_sayisi", Tbx_Total_Amount_Selled_Products.Text);
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_fiyati", Tbx_Total_Price_Selled_Products.Text);
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_alis_fiyati", denemebox.Text);
                    datacommand2.ExecuteNonQuery();
                    context.CalculateListedProductsPrice(Dgw_Products, Tbx_Listed_Products_Price);
                    context.CalculateListedProductsAmount(Dgw_Products, Tbx_Listed_Products_Amount);




                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            con.Open();
            DialogResult KapanisKontrolu = 0;
            try
            {
                double karMarjı = (Double.Parse(Tbx_Total_Price_Selled_Products.Text) - Double.Parse(denemebox.Text));

                KapanisKontrolu = MessageBox.Show("Bu gün için kârınız :" + karMarjı.ToString(), " Gün içinde yapmış olduğunuz kâr", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (System.FormatException)
            {
                DialogResult satisYapilmadıKutusu = MessageBox.Show("Bu gün hiç satış yapılmadı");
                if (satisYapilmadıKutusu == DialogResult.OK)
                {
                    this.Close();
                    Application.Exit();
                }

            }
            finally
            {
                if (KapanisKontrolu == DialogResult.OK || con.State == ConnectionState.Closed)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand datacommand2 = new SqlCommand("UPDATE SelledTable set satilan_urun_sayisi=@satilan_urun_sayisi, satilan_urunlerin_toplam_fiyati=@satilan_urunlerin_toplam_fiyati,satilan_urunlerin_toplam_alis_fiyati=@satilan_urunlerin_toplam_alis_fiyati", con);
                    datacommand2.Parameters.AddWithValue("@satilan_urun_sayisi", "");
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_fiyati", "");
                    datacommand2.Parameters.AddWithValue("@satilan_urunlerin_toplam_alis_fiyati", "");
                    Tbx_Total_Amount_Selled_Products.Text = "";
                    Tbx_Total_Price_Selled_Products.Text = "";
                    denemebox.Text = "";
                    datacommand2.ExecuteNonQuery();
                    this.Close();
                    Application.Exit();

                }
                else if (KapanisKontrolu == DialogResult.Cancel)
                {
                    MessageBox.Show("Kapanış iptal edildi");

                }
                con.Close();
            }
        }
    }
}
    
