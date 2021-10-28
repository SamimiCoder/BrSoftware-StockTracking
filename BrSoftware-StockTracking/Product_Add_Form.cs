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
    public partial class Product_Add_Form : DevExpress.XtraEditors.XtraForm
    {
        public Product_Add_Form()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        static SqlCommand sqlCommand;
        static SqlConnection connection;
        BrstockContext context = new BrstockContext();
        Form1 form1 = new Form1();
        public static SqlConnection getConnect()
        {
            //
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            return connection;

        }

        public static SqlCommand getSqlCommand()
        {

            sqlCommand = new SqlCommand("insert into brstockTable(urun_ismi,urun_kategori,urun_satıs_fiyat,stok_miktarı,urun_alıs_fiyat) values (@urun_ismi,@urun_kategori,@urun_satıs_fiyat,@stok_miktarı,@urun_alıs_fiyat)", getConnect());
            return sqlCommand;
        }


       

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Tbx_Product_Buy_Price.Text.Equals("") || Tbx_Product_Buy_Price.Text.Equals(" ") || Tbx_Product_Category.Text.Equals("") || Tbx_Product_Category.Text.Equals(" ") || Tbx_Product_Name.Text.Equals("") || Tbx_Product_Name.Text.Equals(" ")
                || Tbx_Product_Price.Text.Equals("") || Tbx_Product_Price.Text.Equals(" ") || Tbx_Product_Stock_Amount.Text.Equals("") || Tbx_Product_Stock_Amount.Text.Equals(" "))
            {
                MessageBox.Show("BOŞ BIRAKILAMAZ");
            }
            else
            {
                try
                {

                    form1.Dgw_Products.DataSource = null;
                    sqlCommand = Product_Add_Form.getSqlCommand();

                    sqlCommand.Parameters.Add("@urun_ismi", (SqlDbType.NVarChar)).Value = Tbx_Product_Name.Text;

                    sqlCommand.Parameters.Add("@urun_kategori", (SqlDbType.NVarChar)).Value = Tbx_Product_Category.Text;

                    sqlCommand.Parameters.Add("@urun_satıs_fiyat", (SqlDbType.Float)).Value = Tbx_Product_Price.Text;

                    sqlCommand.Parameters.Add("@stok_miktarı", (SqlDbType.Int)).Value = Tbx_Product_Stock_Amount.Text;

                    sqlCommand.Parameters.Add("@urun_alıs_fiyat", (SqlDbType.Float)).Value = Tbx_Product_Buy_Price.Text;

                    sqlCommand.ExecuteNonQuery();

                    connection.Close();


                    form1 = (Form1)Application.OpenForms["Form1"];
                    form1.SendDataToGridView();
                    context.CalculateListedProductsPrice(form1.Dgw_Products, form1.Tbx_Listed_Products_Price);
                    context.CalculateListedProductsAmount(form1.Dgw_Products, form1.Tbx_Listed_Products_Amount);
                    connection.Close();


                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }
                catch (System.FormatException)
                {

                    MessageBox.Show("SAYI YERİNE HARF YAZDINIZ LÜTFEN DOĞRU BİR ŞEKİLDE YAZIN");
                }





            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Tbx_Product_Buy_Price.Text = "";
            Tbx_Product_Category.Text = "";
            Tbx_Product_Name.Text = "";
            Tbx_Product_Price.Text = "";
            Tbx_Product_Stock_Amount.Text = "";
        }
    }
}
    
