using System;
using IParse.Models;
using Microsoft.AspNetCore.Mvc;

namespace IParse.Controllers
{
    public class RequestQuestionController : Controller
    {
        private IRequestQuestionRepository repository;

        public RequestQuestionController(IRequestQuestionRepository questionRepository)
        {
            repository = questionRepository;
        }

        public ViewResult RequestQuestion() => View(new RequestQuestion());

        [HttpPost]
        public IActionResult RequestQuestion(RequestQuestion requestQuestion)
        {
            if(ModelState.IsValid)
            {
                repository.SaveRequestQuestion(requestQuestion);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View("Index");
            }
        }

        private object Completed()
        {
            return View();
        }
    }
}