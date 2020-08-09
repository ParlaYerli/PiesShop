using DataAccess.Abstract;
using Entities;
using Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        public CategoryRepository(AppDbContext _context)
        {
            this._context = _context;
        }
        public IEnumerable<Category> AllCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
