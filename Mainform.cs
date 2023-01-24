using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void авторизация_Click(object sender, EventArgs e)
        {
            Form Log = new LoginForm();
            Log.Show();
            this.Hide();
        }

        private void регистрация_Click(object sender, EventArgs e)
        {
            Form Reg = new Regform();
            Reg.Show();
            this.Hide();
        }

        private void выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
