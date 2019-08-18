using DAL.Moldels;
using DAL.Repositories;
using FirstWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class BikeController : Controller
    {
        private BranchRepository branchRepo;
        private BikeRepository bikeRepo;

        public BikeController()
        {
            bikeRepo = new BikeRepository();
            branchRepo = new BranchRepository();
        }

        public ActionResult Create()
        {
            var viewModel = new BikeCreateViewModel();
            viewModel.AvailableBranches = branchRepo.Get();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreatePost(BikeCreateViewModel model)
        {
            if (model.New.BranchId <= 0) { }
            else
                bikeRepo.Create(model.New);

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {

            var bike = bikeRepo.Get();
            return View(bike);
        }

    }
}