using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp2
{
    public partial class GLAV : Form
    {
        public GLAV()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = $"Главная форма - {CurrentUser.Username} ({CurrentUser.Role})";
            this.Size = new Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

            Button btnAdmin = new Button()
            {
                Text = "Админ панель",
                Location = new Point(10, 10),
                Size = new Size(150, 30)
            };

            Button btnUser = new Button()
            {
                Text = "Меню",
                Location = new Point(10, 50),
                Size = new Size(150, 30)
            };

            Button btnLogout = new Button()
            {
                Text = "Выйти",
                Location = new Point(10, 90),
                Size = new Size(150, 30)
            };

            if (CurrentUser.IsAdmin())
            {
                btnAdmin.Visible = true;
                btnAdmin.Click += (s, e) => ShowAdminPanel();
            }
            else
            {
                btnAdmin.Visible = false;
            }

            // ИЗМЕНЕНИЕ: Разные формы для админа и пользователя
            btnUser.Click += (s, e) => ShowUserForm();

            btnLogout.Click += (s, e) => Logout();

            this.Controls.AddRange(new Control[] { btnAdmin, btnUser, btnLogout });
        }

        private void ShowAdminPanel()
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void ShowUserForm()
        {
            // АДМИН открывает Form1
            if (CurrentUser.IsAdmin())
            {
                Form2 adminUserForm = new Form2();
                adminUserForm.Show();
            }
            // ПОЛЬЗОВАТЕЛЬ открывает UserForm
            else
            {
                FormMENU userForm = new FormMENU();
                userForm.Show();
            }
        }

        private void Logout()
        {
            CurrentUser.Clear();
            login loginForm = new login();
            loginForm.Show();
            this.Close();
        }
    }
}