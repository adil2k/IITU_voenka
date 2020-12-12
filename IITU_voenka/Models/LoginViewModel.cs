using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IITU_voenka.Models
{
    public class LoginViewModel : IValidatableObject
    {
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(this.UserName))
            {
                errors.Add(new ValidationResult("Введите логин"));
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                errors.Add(new ValidationResult("Введите пароль"));
            }

            return errors;
        }
    }
}
