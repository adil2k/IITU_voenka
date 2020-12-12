using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IITU_voenka.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги")]
        public override string Title { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Длина строки должна быть от 5 до 50 символов")]
        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10 до 100 символов")]
        [Display(Name = "Полное описание услуги")]
        public override string Text { get; set; }
    }
}
