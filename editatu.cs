using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ENTREGA2
{
    public partial class editatu : Form
    {

        private string nanOriginal; // Para identificar el registro a actualizar

        public editatu(
            string izena, string abizena1, string abizena2, string nan, string jaiotza_data,
            string posta, string telefono, string helbidea)
        {
            InitializeComponent();

            // Guardamos el identificador
            nanOriginal = nan;

            // Rellenamos los campos con los datos recibidos
            txtIzena.Text = izena;
            txtAbizena1.Text = abizena1;
            txtAbizena2.Text = abizena2;
            txtNan.Text = nan;
            txtJaiotzaData.Text = jaiotza_data;
            txtPosta.Text = posta;
            txtTelefono.Text = telefono;
            txtHelbidea.Text = helbidea;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Konexioa.Konexioa konexioa = new Konexioa.Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = @"UPDATE erabiltzaileak 
                                    SET izena = @izena,
                                        abizena1 = @abizena1,
                                        abizena2 = @abizena2,
                                        nan = @nan,
                                        jaiotza_data = @jaiotza_data,
                                        posta_elektronikoa = @posta,
                                        telefono_zenbakia = @telefono,
                                        helbidea = @helbidea
                                    WHERE nan = @nanOriginal";

                    using (MySqlCommand cmd = new MySqlCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("@izena", txtIzena.Text);
                        cmd.Parameters.AddWithValue("@abizena1", txtAbizena1.Text);
                        cmd.Parameters.AddWithValue("@abizena2", txtAbizena2.Text);
                        cmd.Parameters.AddWithValue("@nan", txtNan.Text);
                        cmd.Parameters.AddWithValue("@jaiotza_data", txtJaiotzaData.Text);
                        cmd.Parameters.AddWithValue("@posta", txtPosta.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@helbidea", txtHelbidea.Text);
                        cmd.Parameters.AddWithValue("@nanOriginal", nanOriginal);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Erabiltzailea eguneratu da!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea eguneratzean: " + ex.Message);
            }
        }
    }

}

