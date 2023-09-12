using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MVCWebUI.Models;

namespace MVCWebUI.ViewComponents
{
	public class CategoryListViewComponent:ViewComponent
	{
		ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
			_categoryService = categoryService;
            
        }
        public ViewViewComponentResult Invoke()
		{
			var model = new CategoryListViewModel
			{
				Categories = _categoryService.GetAll()
			};
			return View(model);
		}
	}
}
