using System.IO.Packaging;
using System.Text.RegularExpressions;
using Registro_de_alumnos.clases;

namespace Registro_de_alumnos
{
    public partial class Register : Form
    {
        Form_login loginForm;
        List<Postulante> listPostulant = new List<Postulante>();
        private string filePath;
        public Register(Form_login form)
        {
            this.loginForm = form;
            InitializeComponent();
            this.getPath();
            this.readAndShowPostulant();


        }

        private void getPath()
        {
            string appContextBase = AppContext.BaseDirectory.Split("bin")[0];
            this.filePath = appContextBase + "assets/Postulantes.txt";
        }

        private void readAndShowPostulant()
        {

            var fileTextLines = File.ReadLines(filePath);
            foreach (var item in fileTextLines)
            {
                Postulante postulant = Postulante.FromString(item);
                listPostulant.Add(postulant);
                this.showPostulant(postulant);
            }

        }

        private void showPostulant(Postulante postulant)
        {
            int row = dtgvPostulant.Rows.Add();
            dtgvPostulant.Rows[row].Cells[0].Value = postulant.getName();
            dtgvPostulant.Rows[row].Cells[1].Value = postulant.getLastName();
            dtgvPostulant.Rows[row].Cells[2].Value = postulant.getType();
            dtgvPostulant.Rows[row].Cells[3].Value = postulant.getNumber();
        }

        private void writeData()
        {
            string[] postulants = listPostulant.ConvertAll(postulant => postulant.ToString()).ToArray();
            File.WriteAllLines(filePath, postulants);
        }



        private void btnIn_Click(object sender, EventArgs e)
        {



            if (txtName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && cboType.Text.Trim() != "" && txtNumber.Text.Trim() != "")
            {
                Postulante newPostulant = new Postulante(txtName.Text.Trim(), txtLastName.Text.Trim(), (DNI)Enum.Parse(typeof(DNI), cboType.Text), int.Parse(txtNumber.Text.Trim()));
                this.listPostulant.Add(newPostulant);
                this.showPostulant(newPostulant);
                using (StreamWriter w = File.AppendText(filePath))
                {
                    w.WriteLine(newPostulant.ToString());
                }
            }
            else
            {
                Alert alert = new Alert("No se admiten campos vacíos");
                alert.ShowDialog();
            }

            this.clearForm();
        }

        private void clearForm()
        {
            txtName.Clear();
            txtLastName.Clear();
            cboType.Text = "";
            txtNumber.Clear();
        }

        private void dtgvPostulant_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelected = e.RowIndex;
            dtgvPostulant.Rows.RemoveAt(rowSelected);
            this.listPostulant.RemoveAt(rowSelected);
            this.writeData();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clearForm();
        }
    }
}
