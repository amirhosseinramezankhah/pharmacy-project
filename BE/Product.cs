﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Product
    {
        public Product() 
        {
            DeleteStatus = false;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool DeleteStatus { get; set; }
        // stock = تعداد آن محصول موردنظر یا کالای مورد نظر
        public int Stock { get; set; } 
        public DateTime RegDate { get; set; }
        public double SumPrice { get; set; }
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public Customer Customer { get; set; }
       


    }
}
