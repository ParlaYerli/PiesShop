using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopWeb.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PieOfTheWeek { get; set; }
    }
}
