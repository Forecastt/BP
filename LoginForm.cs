using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 46);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Войти_Click(object sender, EventArgs e)
        {
            String loginUser = LogField.Text;
            String passUser = PassField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Welcome back!");
                Form Gen = new Generationform();
                Gen.Show();
                this.Hide();
            }
            else
                MessageBox.Show("User not found");


        }

        private void PassField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogField_TextChanged(object sender, EventArgs e)
        {

        }

        private void Backtomenu_Click(object sender, EventArgs e)
        {
            Form Back = new Mainform();
            Back.Show();
            this.Hide();
        }
    }
}
