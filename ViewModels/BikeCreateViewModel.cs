using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.ViewModels
{
    public class BikeCreateViewModel
    {
        public Bike New { get; set; }
        public List<Branch> AvailableBranches { get; set; }
    }
}