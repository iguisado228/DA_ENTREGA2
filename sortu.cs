using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using Konexioa;

namespace DA_ENTREGA2
{
    public partial class sortu : Form
    {
        public sortu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void insertatu_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Konexioa.Konexioa konexioa = new Konexioa.Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = @"INSERT INTO erabiltzaileak 
                                    (izena, abizena1, abizena2, nan, jaiotza_data, posta_elektronikoa, telefono_zenbakia, helbidea) 
                                    VALUES (@izena, @abizena1, @abizena2, @nan, @jaiotza_data, @posta, @telefono, @helbidea)";

                    using (MySqlCommand cmd = new MySqlCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("@izena", txtIzena.Text);
                        cmd.Parameters.AddWithValue("@abizena1", txtAbizena1.Text);
                        cmd.Parameters.AddWithValue("@abizena2", txtAbizena2.Text);
                        cmd.Parameters.AddWithValue("@nan", txtNan.Text);

                        DateTime jaiotzaData;
                        if (DateTime.TryParse(txtJaiotzaData.Text, out jaiotzaData))
                        {
                            cmd.Parameters.AddWithValue("@jaiotza_data", jaiotzaData);
                        }
                        else
                        {
                            MessageBox.Show("Jaiotza data ez da baliozkoa (formatoa: yyyy-MM-dd).");
                            return;
                        }

                        cmd.Parameters.AddWithValue("@posta", txtPosta.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@helbidea", txtHelbidea.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Erabiltzailea gehitu da!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea gehitzean: " + ex.Message);
            }
        }

        private void sortu_Load(object sender, EventArgs e)
        {

        }
    }
}
