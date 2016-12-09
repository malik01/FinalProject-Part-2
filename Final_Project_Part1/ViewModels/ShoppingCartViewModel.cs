using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project_Part1.Models;

namespace Final_Project_Part1.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}