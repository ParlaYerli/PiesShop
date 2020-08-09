using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies();
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
        Category GetCategory(int pieId);
    }
}
