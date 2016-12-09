using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Final_Project_Part1.Models;

namespace Final_Project_Part1.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public int CartCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteId { get; set; }
    }
}