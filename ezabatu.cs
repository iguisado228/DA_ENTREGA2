using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace DA_ENTREGA2
{
    public static class ezabatu
    {
        public static void erabiltzaileaEzabatu(string nan)
        {
            DialogResult respuesta = MessageBox.Show(
                "Ziur zaude erabiltzaile hau ezabatu nahi duzula?",
                "Berrespena",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                Konexioa.Konexioa konexioa = new Konexioa.Konexioa();

                using (MySqlConnection kon = new MySqlConnection(konexioa.konexioKatea()))
                {
                    kon.Open();

                    string query = "DELETE FROM erabiltzaileak WHERE nan = @nan";

                    using (MySqlCommand cmd = new MySqlCommand(query, kon))
                    {
                        cmd.Parameters.AddWithValue("@nan", nan);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Erabiltzailea ezabatu da.");
                        }
                        else
                        {
                            MessageBox.Show("Ez da erabiltzaile hori aurkitu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errorea erabiltzailea ezabitzean: " + ex.Message);
            }
        }
    }
}
