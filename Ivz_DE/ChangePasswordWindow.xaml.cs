using System;
using System.Linq;
using System.Windows;
using Ivz_DE.Models;

namespace Ivz_DE
{
    public partial class ChangePasswordWindow : Window
    {
        private readonly int _userId;
        public ChangePasswordWindow(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            string currentPassword = txtCurrentPassword.Password;
            string newPassword = txtNewPassword.Password;
            string confirmNewPassword = txtConfirmPassword.Password;


            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                MessageBox.Show("Все поля обязательны для заполнения.");
                return;
            }

            // Проверка совладения нового пароля и подтверждения
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Новый пароль и подтверждение не совпадают.");
                return;
            }
        }
    }
}