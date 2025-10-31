using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{

    public partial class login : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Users.accdb;";

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, Role FROM Users WHERE Username = ? AND Password = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Сохраняем данные пользователя
                                CurrentUser.Username = reader["Username"].ToString();
                                CurrentUser.Role = reader["Role"].ToString();

                                // Открываем главную форму
                                GLAV mainForm = new GLAV();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Reg regForm = new Reg();
            regForm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reg regForm = new Reg();
            regForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Показываем пароль
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                // Скрываем пароль
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Показываем пароль
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                // Скрываем пароль
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Reg regForm = new Reg();
            regForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Username, Role FROM Users WHERE Username = ? AND Password = ?";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Сохраняем данные пользователя
                                CurrentUser.Username = reader["Username"].ToString();
                                CurrentUser.Role = reader["Role"].ToString();

                                // Открываем главную форму
                                GLAV mainForm = new GLAV();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}


