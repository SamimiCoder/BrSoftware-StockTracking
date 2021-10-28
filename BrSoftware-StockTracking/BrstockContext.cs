using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrSoftware_StockTracking
{
    class BrstockContext
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=brstock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        internal void SatırSil(int ıd)
        {
            string sql = "DELETE FROM brstockTable WHERE Id=@Id";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@Id", ıd);
            connection.Open();
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

        public void CalculateListedProductsAmount(DataGridView dataGridView, TextBox textBox)
        {

            int adet = 0;
            for (int y = 0; y < dataGridView.Rows.Count; y++)
            {

                adet = adet + Int32.Parse(dataGridView.Rows[y].Cells["stok_miktarı"].Value.ToString());

            }

            textBox.Text = adet.ToString() + " Adet";


        }
        public void CalculateListedProductsPrice(DataGridView dataGridView, TextBox textBox)
        {
            Form1 frmMain = new Form1();


            int stokSayisi = 0;
            double fiyat = 0.0;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {


                stokSayisi = Int32.Parse(dataGridView.Rows[i].Cells[4].Value.ToString());
                fiyat += Double.Parse(dataGridView.Rows[i].Cells["urun_satıs_fiyat"].Value.ToString()) * stokSayisi;

            }
            textBox.Text = fiyat.ToString() + " TL";


        }
        internal void SatırSilSiparis(int ıd)
        {
            connection.Open();
            string sql = "DELETE FROM siparisAyarlariTable where Id=@Id";
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.Parameters.AddWithValue("@Id", ıd);
            
            sqlCommand.ExecuteNonQuery();
            connection.Close();
        }

    }
}
    
