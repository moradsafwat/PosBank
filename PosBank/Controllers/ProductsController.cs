using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PosBank.Services.Interface;
using PosBank.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PosBank.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private readonly IProductsService _productsService;
        private readonly IProductsDetailsService _productsDetailsService;

        public ProductsController(IWebHostEnvironment webHost,
            IProductsService productsService,
           IProductsDetailsService productsDetailsService)
        {
            _webHost = webHost;
            _productsService = productsService;
            _productsDetailsService = productsDetailsService;
        }
        // GET: ProductsController
        public ActionResult Index()
        {
            return View(_productsDetailsService.DetailsJoinProduct());
        }

        // GET: ProductsController/Details/5
        public ActionResult DetailsProduct(int id)
        {
            return View(_productsService.GetById(id));
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProduct(HomePageViewModel productVM)
        {
            try
            {
                string fileName = string.Empty;
                if (ModelState.IsValid)
                {
                    if (productVM.Product.PictureUrl != null)
                    {
                        fileName = productVM.Product.PictureUrl.FileName;
                        string fullPath = Path.Combine(Path.Combine(_webHost.WebRootPath, "assets/media/Uploads"), fileName);
                        productVM.Product.PictureUrl.CopyTo(new FileStream(fullPath, FileMode.Create));
                    };

                    productVM.Product.PictureVM = fileName;
                    
                    _productsService.Create(productVM.Product);
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            catch
            {
                return View();
            }

        }

        // GET: ProductsController/Edit/5
        public ActionResult EditProduct(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult DeleteProduct(int id)
        {
            return View(_productsService.GetById(id));
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int id, ProductViewModel productVm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productsService.Delete(productVm);
                    return RedirectToAction("Index", "Home");
                }
                return View();
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
