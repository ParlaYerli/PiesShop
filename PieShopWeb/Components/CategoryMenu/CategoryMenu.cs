using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopWeb.Components.CategoryMenu
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository _categoryRepository)
        {
            this._categoryRepository = _categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories().OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
