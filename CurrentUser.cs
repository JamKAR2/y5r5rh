using System;

namespace WindowsFormsApp2
{
    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static int UserId { get; set; }

        public static void Clear()
        {
            Username = null;
            Role = null;
            UserId = 0;
        }

        public static bool IsAdmin()
        {
            return Role == "admin";
        }

        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(Username);
        }

        // Новый метод для проверки главного админа (можно настроить логику)
        public static bool IsMainAdmin()
        {
            // Например, главный админ - это пользователь с именем "admin"
            return IsAdmin() && Username.ToLower() == "admin";

            // Или можно добавить отдельное поле в базу данных для главного админа
            // return IsAdmin() && IsMainAdminInDatabase;
        }
    }
}