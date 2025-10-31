using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp2
{
    public partial class Reg : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Users.accdb;";

        public Reg()
        {
            InitializeComponent();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = "user"; // По умолчанию регистрируем как пользователя

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                // Проверяем, нет ли уже такого пользователя
                if (UserExists(username))
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!");
                    return;
                }

                string insertQuery = "INSERT INTO Users (Username, [Password], Role) VALUES (?, ?, ?)";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@Role", role);

                    conn.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация успешна!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации!");
                    }
                }
            }
            catch (Exception ex) // ДОБАВЛЕН закрывающий блок catch
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private bool UserExists(string username)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Показываем пароль
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                // Скрываем пароль
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Показываем пароль
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                // Скрываем пароль
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = "user"; // По умолчанию регистрируем как пользователя

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                // Проверяем, нет ли уже такого пользователя
                if (UserExists(username))
                {
                    MessageBox.Show("Пользователь с таким именем уже существует!");
                    return;
                }

                string insertQuery = "INSERT INTO Users (Username, [Password], Role) VALUES (?, ?, ?)";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", password);
                    insertCmd.Parameters.AddWithValue("@Role", role);

                    conn.Open();
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация успешна!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации!");
                    }
                }
            }
            catch (Exception ex) // ДОБАВЛЕН закрывающий блок catch
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
