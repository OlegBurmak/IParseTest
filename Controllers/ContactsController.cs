using System.Collections.Generic;
using IParse.Models;
using Microsoft.AspNetCore.Mvc;

namespace IParse.Controllers
{
    public class ContactsController : Controller
    {
        private IRequestQuestionRepository requestQuestionRepository;

        public ContactsController(IRequestQuestionRepository requestQuestionRepo)
        {
            requestQuestionRepository = requestQuestionRepo;
        }


        public ViewResult RequestQuestion()
        {
            var requestQuestion = new RequestQuestion();
            requestQuestion.ContactsDatas = new List<ContactsData> { 
            new ContactsData { Icon = "icon-map-o", NameField = "Address", Description = "198 West 21th Street, Suite 721 New York NY 10016"},
            new ContactsData { Icon = "icon-mobile-phone", NameField = "Phone", Description = "+3809555655"},
            new ContactsData { Icon = "icon-envelope-o", NameField = "Email", Description = "iparse@gmail.com"}
            };
            return View(requestQuestion);
        }

        [HttpPost]
        public IActionResult RequestQuestion(RequestQuestion requestQuestion)
        {
            if(ModelState.IsValid)
            {
                requestQuestionRepository.SaveRequestQuestion(requestQuestion);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View();
            }
        }

        public ViewResult Completed()
        {
            return View();
        }
    }
}