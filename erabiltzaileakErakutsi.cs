using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Konexioa;// importante: para usar la clase Konexioa

namespace DA_ENTREGA2
{
    public partial class erabiltzaileakErakutsi : Form
    {
        public erabiltzaileakErakutsi()
        {
            InitializeComponent();
            KargatuErabiltzaileak();
        }

        private void KargatuErabiltzaileak()
        {
            // Crear una instancia de tu clase de conexión
            Konexioa.Konexioa konexioa = new Konexioa.Konexioa();

            // Consulta SQL
            string kontsulta = "SELECT izena, abizena1, abizena2, nan, jaiotza_data, posta_elektronikoa, telefono_zenbakia, helbidea FROM erabiltzaileak";

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

        private void erabiltzaileakErakutsi_Load(object sender, EventArgs e)
        {
            // Aquí no hace falta nada si ya llamas a KargatuErabiltzaileak() en el constructor
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
