using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.ViewModels
{
    public class CarCreateViewModel
    {
        public Car New { get; set; }
        public List<Branch> AvailableBranches { get; set; }

    }
}