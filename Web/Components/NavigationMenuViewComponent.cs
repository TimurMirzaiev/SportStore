﻿using Data.Entities;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IRepository<Product> _productRepository;

        public NavigationMenuViewComponent(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            var products = _productRepository.Get()
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(products);
        }
    }
}
