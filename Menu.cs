using System;
using System.Windows.Forms;

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
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Ongi etorri, " + langilea.erabiltzaile_izena;
        }
    }
}
