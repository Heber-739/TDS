using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_alumnos
{
    public partial class Alert : Form
    {
        public Alert(string message)
        {
            InitializeComponent();

            lblMessage.Text = message.Trim();

            Rezise();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Rezise()
        {
            this.Width = lblMessage.Width + 60;
            this.Height = lblMessage.Height + btnAccept.Height + 150;

            lblMessage.Left = (this.Width - lblMessage.Width - 10) / 2;
            lblMessage.Top = 50;

            btnAccept.Left = (this.Width - btnAccept.Width) / 2;
            btnAccept.Top = (this.Height - btnAccept.Height - 60);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
