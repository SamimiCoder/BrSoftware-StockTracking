using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrSoftware_StockTracking
{
    public partial class Frm_Debt_Follow : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Debt_Follow()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataSet ds;
        DataSet ds1;
        SqlCommandBuilder cmdb;
        BrstockContext context = new BrstockContext();

        public void DatagridSettingsForİn()
        {
            dgw_Debt_İn.AllowUserToAddRows = false;
            dgw_Debt_İn.Columns["Id"].HeaderText = "ID";
            dgw_Debt_İn.Columns["verecek_isim_soyisim"].HeaderText = "Adı Soyadı";
            dgw_Debt_İn.Columns["verecek_borc_miktari"].HeaderText = "Borç Miktarı";
            dgw_Debt_İn.Columns["verecek_son_odeme_tarihi"].HeaderText = "Son Ödeme Tarihi";
            dgw_Debt_İn.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgw_Debt_İn.EnableHeadersVisualStyles = false;
            dgw_Debt_İn.Columns["Id"].DefaultCellStyle.BackColor = Color.Gray;
            dgw_Debt_İn.Columns["verecek_borc_miktari"].DefaultCellStyle.BackColor = Color.Silver;
            dgw_Debt_İn.Columns["verecek_isim_soyisim"].DefaultCellStyle.BackColor = Color.Silver;
            dgw_Debt_İn.Columns["verecek_son_odeme_tarihi"].DefaultCellStyle.BackColor = Color.Gray;
            dgw_Debt_İn.Columns["verecek_borc_miktari"].DefaultCellStyle.Format = "C2";


        }
        public void DatagridSettingsForOut()
        {
            dgw_debt_Out.AllowUserToAddRows = false;
            dgw_debt_Out.Columns["Id"].HeaderText = "İD";
            dgw_debt_Out.Columns["alacakli_isim_soyisim"].HeaderText = "Adı Soyadı";
            dgw_debt_Out.Columns["alacakli_borc_miktari"].HeaderText = "Borç Miktarı";
            dgw_debt_Out.Columns["son_odeme_tarihi"].HeaderText = "Son Ödeme Tarihi";
            dgw_debt_Out.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgw_debt_Out.EnableHeadersVisualStyles = false;
            dgw_debt_Out.Columns["Id"].DefaultCellStyle.BackColor = Color.Gray;
            dgw_debt_Out.Columns["alacakli_isim_soyisim"].DefaultCellStyle.BackColor = Color.Silver;
            dgw_debt_Out.Columns["alacakli_borc_miktari"].DefaultCellStyle.BackColor = Color.Silver;
            dgw_debt_Out.Columns["son_odeme_tarihi"].DefaultCellStyle.BackColor = Color.Gray;
            dgw_debt_Out.Columns["son_odeme_tarihi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgw_debt_Out.Columns["alacakli_borc_miktari"].DefaultCellStyle.Format = "C2";


        }
        public void GridİnDoldur()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            da1 = new SqlDataAdapter("Select * from DebtİnTable", con);
            cmdb = new SqlCommandBuilder(da1);
            ds1 = new DataSet();
            da1.Fill(ds1, "DebtİnTable");
            dgw_Debt_İn.DataSource = ds1.Tables[0];
            con.Close();
        }
        public void GridOutDoldur()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            da = new SqlDataAdapter("Select * from DebtOutTable", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "DebtOutTable");
            dgw_debt_Out.DataSource = ds.Tables[0];
            con.Close();
            DatagridSettingsForOut();
        }
        

        public void SatırSilForOut(int ıd)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "DELETE FROM DebtOutTable WHERE Id=@Id";
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            sqlCommand.Parameters.AddWithValue("@Id", ıd);
            sqlCommand.ExecuteNonQuery();
            Update_Calculated_Debts_Price();
            con.Close();
        }
        public void SatırSilForİn(int ıd)
        {
            con.Open();
            string sql = "DELETE FROM DebtİnTable WHERE Id=@Id";
            SqlCommand sqlCommand = new SqlCommand(sql, con);
            sqlCommand.Parameters.AddWithValue("@Id", ıd);

            sqlCommand.ExecuteNonQuery();

            con.Close();
        }

        
        public void Calculate_Debts_Price()
        {
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            da = new SqlDataAdapter("Select * from CalculateDebtsTable", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "CalculateDebtsTable");
            SqlCommand cmd = new SqlCommand("Select [toplam_alinacak_borc_miktari],[toplam_verilecek_borc_miktari] from CalculateDebtsTable", con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            Tbx_Toplam_Alınacak_Borc.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(dr["toplam_alinacak_borc_miktari"].ToString()));
            Tbx_Toplam_Borc.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(dr["toplam_verilecek_borc_miktari"].ToString()));
            con.Close();
        }
        public void Update_Calculated_Debts_Price()
        {

            decimal OutBorcMiktari = 0;
            string borc;
            for (int i = 0; i < dgw_debt_Out.Rows.Count; i++)
            {

                OutBorcMiktari += decimal.Parse(dgw_debt_Out.Rows[i].Cells["alacakli_borc_miktari"].Value.ToString());
            }
            Tbx_Toplam_Borc.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(OutBorcMiktari.ToString()));
            decimal İnBorcMiktari = 0;
            for (int i = 0; i < dgw_Debt_İn.Rows.Count; i++)
            {
                İnBorcMiktari += decimal.Parse(dgw_Debt_İn.Rows[i].Cells["verecek_borc_miktari"].Value.ToString()); //bunu yapmasını öğrendim abi izninle göstereyim
            }
            Tbx_Toplam_Alınacak_Borc.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", Convert.ToDecimal(İnBorcMiktari.ToString())); //abi son bir adım kaldı her borç eklendiğinde bu veriler artacak silinince azalacak şuandada azalır zaten çünkü orada olmaycak deneyelim ab
        }

        

        public void OutGuncelle()
        {
            try
            {

                da.Update(ds, ds.Tables[0].TableName);

                MessageBox.Show("BORÇ BİLGİSİ GÜNCELLENDİ");
                GridOutDoldur();
                Update_Calculated_Debts_Price();
            }
            catch (System.FormatException)
            {

                MessageBox.Show("YANLIŞ VERİ GİRİŞİ YAPTINIZ");
            }
        }

        

        private void Frm_Debt_Follow_Load_1(object sender, EventArgs e)
        {
            GridOutDoldur();
            GridİnDoldur();
            DatagridSettingsForİn();


            Calculate_Debts_Price();
            Update_Calculated_Debts_Price();
        }

        

        private void tbx_Search2_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt1 = ds1.Tables[0];
            DataView dataView1 = dt1.DefaultView;
            dataView1.RowFilter = String.Format("verecek_isim_soyisim LIKE '" + tbx_Search2.Text + "%'");
            dgw_Debt_İn.DataSource = dataView1;
        }

        private void tbx_Search_TextChanged_1(object sender, EventArgs e)
        {
            GridOutDoldur();
            DataTable dt = ds.Tables[0];
            DataView dataView = dt.DefaultView;
            dataView.RowFilter = String.Format("alacakli_isim_soyisim LIKE '" + tbx_Search.Text + "%'");
            dgw_debt_Out.DataSource = dataView;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            OutGuncelle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_Add_Debt_Out _Add_Debt_Out = new Frm_Add_Debt_Out();
            _Add_Debt_Out.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgw_debt_Out.SelectedRows)
            {
                int Id = Convert.ToInt32(drow.Cells[0].Value);
                SatırSilForOut(Id);
                GridOutDoldur();
                Update_Calculated_Debts_Price();
            }
        }

        

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Frm_Add_İn_Debt frm_Add_İn_Debt = new Frm_Add_İn_Debt();
            frm_Add_İn_Debt.Show();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgw_Debt_İn.SelectedRows)
            {
                int Id = Convert.ToInt32(drow.Cells[0].Value);
                SatırSilForİn(Id);
                GridİnDoldur();
                Update_Calculated_Debts_Price();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {

                da1.Update(ds1, "DebtİnTable");
                MessageBox.Show("BORÇ BİLGİSİ GÜNCELLENDİ");
                GridİnDoldur();//
                Update_Calculated_Debts_Price();
            }
            catch (System.FormatException)
            {

                MessageBox.Show("YANLIŞ VERİ GİRİŞİ YAPTINIZ");
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


    
