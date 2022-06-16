
using FT_MarketStore.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace FT_MarketStore.ViewModels
{
    public class Checkout
    { 
        public List<Product> products { get; set; }
        public IFormFile myFile { get; set; }


    }
}
