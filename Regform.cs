using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Regform : Form
    {
        public Regform()
        {
            InitializeComponent();
        }

        private void выход_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegField_Click(object sender, EventArgs e)
        {
            if (LogField.Text == "Введите логин")
                return;

            if (PassField.Text == "Введите пароль")
                return;

            if (isUserExist())
                return;
            
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @pass);", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LogField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();


        }
        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LogField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else
                return false;

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

        private void PassField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
