﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rajwinder_Shopping_Centre_API.Modals
    //this class is created for giving the information about product name,type,price and brand and catagory name
{
    public class Product
    {
        public int Id { get; set; }
        [Required]

        public string Product_Name { get; set; }
        [Required]
        public string Product_Type { get; set; }
        [Required]
        public decimal Product_Price { get; set; }
        [Required]
        public string Brand_Name { get; set; }
        [Required]
        public string Category_Name { get; set; }

    }
}
