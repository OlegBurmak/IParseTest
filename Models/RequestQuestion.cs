using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IParse.Models
{
    public class RequestQuestion
    {
        public int RequestQuestionId { get; set; }
        [Required(ErrorMessage = "Введите имя")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Введите фамилию")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Введите електроную почту")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Введите номер телефона")]
        public string Phone { get; set; }
        public string Message { get; set; }

        public List<ContactsData> ContactsDatas { get; set; }
    }
}