using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork2._2.Models
{
    public class UserModel
    {
        public class RegistrationModel
        {
            [Required(ErrorMessage = "Не указано имя")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
            public string Name { get; set; }

            [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
            public string SecondName { get; set; }

            [Required(ErrorMessage = "Не указано Логин")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
            public string Login { get; set; }

            [Required(ErrorMessage = "Не указано Пароль")]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
            public string Password { get; set; }

            [Compare("Password", ErrorMessage = "Пароль не совпадают")]
            public string ConfirmPassword { get; set; }

            [EmailAddress(ErrorMessage = "Некорректный адрес")]
            [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
            public string Email { get; set; }

            [EmailAddress(ErrorMessage = "Некорректный адрес")]
            [Compare("Email", ErrorMessage = "Email не совпадают")]
            public string ConfirmEmail { get; set; }
        }
        public class AuthorizationModel
        {
            [Required]
            public string Name { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 50 символов")]
            public string Password { get; set; }
        }
    }

    
}