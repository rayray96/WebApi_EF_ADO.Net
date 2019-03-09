﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Interfaces;

namespace WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
    }
}