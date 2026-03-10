using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {

        string connString = "Data Source=Faizsltn-27\\FAIZSLTN;Initial Catalog=DBAkademikADO;Integrated Security=True";

        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                
                conn.Open();
                
                lblStatus1.Text = "Status : Database Connected";

                MessageBox.Show("Koneksi berhasil");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Koneksi gagal : " + ex.Message);
            }
           
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();

                    lblStatus2.Text = "Status : Database Disconnected";

                    MessageBox.Show("Koneksi berhasil diputus");
                }
                else
                {
                    MessageBox.Show("Koneksi memang sudah tertutup.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memutuskan koneksi: " + ex.Message);
            }
        }


