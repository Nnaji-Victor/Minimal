using System;
using System.Linq;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Minimal.DataAccess.Repository.IRepository;
using Minimal.Models;
using Minimal.Models.ViewModels;
using Minimal.Utility.Helpers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Minimal.Areas.Admin
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public CategoryController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
            _unitOfWork = unitOfWork;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var categories = _unitOfWork.Category.GetAll();
            return View(categories);
        }

        public IActionResult Upsert(Guid? id)
        {
            var category = new Category();
            if (id == null)
            {
                return View(category);
            }

            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // public IActionResult Upsert(Category category)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         if(category.Id == null)
        //         {
        //             _unitOfWork.Category.Add(category);
        //         }
        //     }
        // }

        #region API Calls
        public IActionResult GetAll()
        {
            var obj = _unitOfWork.Category.GetAll();
            return Json(new { data = obj });
        }

        #endregion
    }
}
