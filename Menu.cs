using System;
using System.Data;
using System.Windows.Forms;
using Konexioa;
using MySql.Data.MySqlClient;

namespace DA_ENTREGA2
{
    public partial class Menu : Form
    {
        private langilea langilea;

        public Menu(langilea l)
        {
            InitializeComponent();   
            langilea = l;
            this.Load += new EventHandler(Menu_Load);
            KargatuErabiltzaileak();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void KargatuErabiltzaileak()
        {
            Konexioa.Konexioa konexioa = new Konexioa.Konexioa();

            string kontsulta = "SELECT izena AS 'Izena', abizena1 AS 'Lehen abizena', abizena2 AS 'Bigarren abizena', nan AS 'NAN-a', jaiotza_data AS 'Jaiotza data', posta_elektronikoa AS 'Posta elektronikoa', telefono_zenbakia AS 'Telefono zenbakia', helbidea AS 'Helbidea' FROM erabiltzaileak";

            try
            {
                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(kontsulta, kon))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea datuak kargatzean: " + ex.Message);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Ongi etorri, " + langilea.erabiltzaile_izena;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
