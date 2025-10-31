using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class AdminForm : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Users.accdb;";
        private DataGridView dgvUsers;

        public AdminForm()
        {
            InitializeComponent();
            SetupAdminForm();
        }

        private void SetupAdminForm()
        {
            this.Text = "Админ панель - Управление пользователями";
            this.Size = new Size(600, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            // DataGridView для просмотра всех пользователей
            dgvUsers = new DataGridView()
            {
                Location = new Point(10, 10),
                Size = new Size(560, 200),
                ReadOnly = true,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            // Кнопки управления
            Button btnRefresh = new Button()
            {
                Text = "Обновить",
                Location = new Point(10, 220),
                Size = new Size(80, 30)
            };

            Button btnMakeAdmin = new Button()
            {
                Text = "Сделать админом",
                Location = new Point(100, 220),
                Size = new Size(120, 30)
            };

            Button btnRemoveAdmin = new Button()
            {
                Text = "Убрать админку",
                Location = new Point(230, 220),
                Size = new Size(120, 30)
            };

            Button btnDeleteUser = new Button()
            {
                Text = "Удалить пользователя",
                Location = new Point(360, 220),
                Size = new Size(120, 30)
            };

            Button btnClose = new Button()
            {
                Text = "Закрыть",
                Location = new Point(490, 220),
                Size = new Size(80, 30)
            };

            // Label для информации
            Label lblInfo = new Label()
            {
                Text = $"Текущий администратор: {CurrentUser.Username}",
                Location = new Point(10, 260),
                Size = new Size(300, 20),
                ForeColor = Color.Blue
            };

            btnRefresh.Click += (s, e) => LoadUsers();
            btnMakeAdmin.Click += (s, e) => MakeAdmin();
            btnRemoveAdmin.Click += (s, e) => RemoveAdmin();
            btnDeleteUser.Click += (s, e) => DeleteUser();
            btnClose.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] {
                dgvUsers, btnRefresh, btnMakeAdmin, btnRemoveAdmin,
                btnDeleteUser, btnClose, lblInfo
            });

            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    string query = "SELECT ID, Username, Role FROM Users ORDER BY Username";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки пользователей: " + ex.Message);
            }
        }

        private void MakeAdmin()
        {
            if (dgvUsers.CurrentRow != null && dgvUsers.CurrentRow.DataBoundItem != null)
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
                string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
                string currentRole = dgvUsers.CurrentRow.Cells["Role"].Value.ToString();

                if (username == CurrentUser.Username)
                {
                    MessageBox.Show("Нельзя изменять свои собственные права!", "Ошибка");
                    return;
                }

                if (currentRole == "admin")
                {
                    MessageBox.Show("Пользователь уже является администратором!", "Информация");
                    return;
                }

                if (MessageBox.Show($"Назначить пользователя {username} администратором?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        UpdateUserRole(userId, "admin");
                        MessageBox.Show($"Пользователь {username} теперь администратор");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя из списка!");
            }
        }

        private void RemoveAdmin()
        {
            if (dgvUsers.CurrentRow != null && dgvUsers.CurrentRow.DataBoundItem != null)
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
                string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();
                string currentRole = dgvUsers.CurrentRow.Cells["Role"].Value.ToString();

                if (username == CurrentUser.Username)
                {
                    MessageBox.Show("Нельзя снимать права с самого себя!", "Ошибка");
                    return;
                }

                if (currentRole == "user")
                {
                    MessageBox.Show("Пользователь уже не является администратором!", "Информация");
                    return;
                }

                if (MessageBox.Show($"Забрать права администратора у пользователя {username}?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        UpdateUserRole(userId, "user");
                        MessageBox.Show($"Пользователь {username} больше не администратор");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя из списка!");
            }
        }

        private void DeleteUser()
        {
            if (dgvUsers.CurrentRow != null && dgvUsers.CurrentRow.DataBoundItem != null)
            {
                int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["ID"].Value);
                string username = dgvUsers.CurrentRow.Cells["Username"].Value.ToString();

                if (username == CurrentUser.Username)
                {
                    MessageBox.Show("Нельзя удалить самого себя!", "Ошибка");
                    return;
                }

                if (MessageBox.Show($"Удалить пользователя {username}?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        using (OleDbConnection conn = new OleDbConnection(connectionString))
                        {
                            conn.Open();
                            string query = "DELETE FROM Users WHERE ID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@ID", userId);
                                cmd.ExecuteNonQuery();
                                LoadUsers();
                                MessageBox.Show("Пользователь удален");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя из списка!");
            }
        }

        private void UpdateUserRole(int userId, string newRole)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET Role = ? WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Role", newRole);
                    cmd.Parameters.AddWithValue("@ID", userId);
                    cmd.ExecuteNonQuery();
                    LoadUsers(); // Обновляем список
                }
            }
        }
    }
}