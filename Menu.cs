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
            InitializeComponent();   // Usa el generado por el diseñador
            langilea = l;
            this.Load += new EventHandler(Menu_Load);
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

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Ongi etorri, " + langilea.erabiltzaile_izena;
        }

        private void btnEditatu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                // Extraemos los valores de la fila seleccionada
                string izena = fila.Cells["Izena"].Value.ToString();
                string abizena1 = fila.Cells["Lehen abizena"].Value.ToString();
                string abizena2 = fila.Cells["Bigarren abizena"].Value.ToString();
                string nan = fila.Cells["NAN-a"].Value.ToString();
                string jaiotza_data = fila.Cells["Jaiotza data"].Value.ToString();
                string posta = fila.Cells["Posta elektronikoa"].Value.ToString();
                string telefono = fila.Cells["Telefono zenbakia"].Value.ToString();
                string helbidea = fila.Cells["Helbidea"].Value.ToString();

                // Abrimos el formulario de edición con los datos
                editatu ed = new editatu(izena, abizena1, abizena2, nan, jaiotza_data, posta, telefono, helbidea);
                ed.ShowDialog();

                // Refrescamos los datos del grid al volver
                KargatuErabiltzaileak();
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu erabiltzaile bat editatzeko.");
            }
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
