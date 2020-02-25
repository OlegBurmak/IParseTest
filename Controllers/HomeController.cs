using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IParse.Models;
using IParse.Models.ViewModels;

namespace IParse.Controllers
{
    public class HomeController : Controller
    {
        private IHomeSliderRepository sliderRepository;
        private IClientCarouselRepository clientCarouselRepository;
        private IDataCounter dataCounterRepository;
        private IGuttersItem guttersItemRepository;
        private IFeaturesItem featuresItemRepository;
        private IRequestQuestionRepository requestQuestionRepository;

        public HomeController(IHomeSliderRepository sliderRepo, IFeaturesItem featuresItemRepo, 
                IDataCounter dataCounterRepo, IGuttersItem guttersItemRepo, 
                IClientCarouselRepository clientCarouselRepo, IRequestQuestionRepository requestQuestionRepo)
        {
            sliderRepository = sliderRepo;
            featuresItemRepository = featuresItemRepo;
            dataCounterRepository = dataCounterRepo;
            guttersItemRepository = guttersItemRepo;
            clientCarouselRepository = clientCarouselRepo;
            requestQuestionRepository = requestQuestionRepo;
        }

        public IActionResult Index()
        {
            return View(new HomeListViewModel
            {
                Sliders = sliderRepository.Sliders,
                FeaturesItems = featuresItemRepository.FeaturesItems,
                DataCounters = dataCounterRepository.DataCounters,
                GuttersItems = guttersItemRepository.GuttersItems,
                ClientCarousels = clientCarouselRepository.ClientCarousels
            });
        }

        public ViewResult RequestQuestion() => View(new RequestQuestion());

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
                return View("Index");
            }
        }

        public ViewResult Completed()
        {
            return View();
        }

        
    }
}
