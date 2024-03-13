﻿using Shop_Learne.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Learne.Domain.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public TypeProduct Type { get; set; }
        public CategoryProducts CategoryId { get; set; }
    }
}
