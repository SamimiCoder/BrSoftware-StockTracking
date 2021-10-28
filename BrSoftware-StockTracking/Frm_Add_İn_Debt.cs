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
    public partial class Frm_Add_İn_Debt : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Add_İn_Debt()
        {
            InitializeComponent();
        }
        SqlCommand command1;
        Frm_Debt_Follow frm_Debt_Follow = new Frm_Debt_Follow();
        SqlConnection connection;


       

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            if (Tbx_İn_Name.Text.Equals("") || Tbx_İn_Debt_Price.Text.Equals("") || Dtp_İn_Debt_Date.Text.Equals("") || Tbx_İn_Name.Text.Equals(" ") || Tbx_İn_Debt_Price.Text.Equals(" ") || Dtp_İn_Debt_Date.Text.Equals(" "))
            {
                MessageBox.Show("BOŞ BIRAKILAMAZ");
            }
            else
            {
                try
                {


                    frm_Debt_Follow.dgw_debt_Out.DataSource = null;

                    SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into DebtİnTable(verecek_isim_soyisim,verecek_borc_miktari,verecek_son_odeme_tarihi) values (@verecek_isim_soyisim,@verecek_borc_miktari,@verecek_son_odeme_tarihi)", connection);

                    command.Parameters.Add("@verecek_isim_soyisim", (SqlDbType.NVarChar)).Value = Tbx_İn_Name.Text;

                    command.Parameters.Add("@verecek_borc_miktari", (SqlDbType.Money)).Value = Tbx_İn_Debt_Price.Text;

                    command.Parameters.Add("@verecek_son_odeme_tarihi", (SqlDbType.DateTime)).Value = Dtp_İn_Debt_Date.Text;

                    command.ExecuteNonQuery();
                    Frm_Debt_Follow frm_Debt = new Frm_Debt_Follow();
                    frm_Debt_Follow = (Frm_Debt_Follow)Application.OpenForms["Frm_Debt_Follow"];

                    frm_Debt_Follow.GridİnDoldur();
                    frm_Debt_Follow.Update_Calculated_Debts_Price();






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
            Tbx_İn_Debt_Price.Text = "";
            Tbx_İn_Name.Text = "";
        }
    }
}
    