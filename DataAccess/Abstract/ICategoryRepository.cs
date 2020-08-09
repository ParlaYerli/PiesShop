using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories();

    }
}
