using DAL.Repositories;
using FirstWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class CarController : Controller
    {
        private CarRepository carRepo;
        private BranchRepository branchRepo;

        public CarController()
        {
            carRepo = new CarRepository();
            branchRepo = new BranchRepository();
        }

        public ActionResult Create()
        {
            var viewModel = new CarCreateViewModel();
            viewModel.AvailableBranches = branchRepo.Get();

            return View(viewModel);
        }


        public ActionResult Edit(int carId)
        {

            var viewModel = new CarCreateViewModel();
            viewModel.New = carRepo.GetById(carId);
            viewModel.AvailableBranches = branchRepo.Get();



            return View(viewModel);

        }

        public ActionResult Delete(int carId)
        {

            var viewModel = new CarCreateViewModel();
            viewModel.New = carRepo.GetById(carId);
            viewModel.AvailableBranches = branchRepo.Get();



            return View(viewModel);

        }

        [HttpPost]
        public ActionResult DeletePost(CarCreateViewModel model)
        {

            carRepo.Delete(model.New);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult EditPost(CarCreateViewModel model)
        {
            if (model.New.BranchId <= 0) { }
            else
                carRepo.Edit(model.New);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult CreatePost(CarCreateViewModel model)
        {
            if (model.New.BranchId <= 0) { }
            else
                carRepo.Create(model.New);

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {

            var cars = carRepo.Get();
            return View(cars);
        }


    }
}