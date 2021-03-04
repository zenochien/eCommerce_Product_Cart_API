﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Language
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public List<ProductTranslations> ProductTranslations { get; set; }

        public List<CategoryTranslations> CategoryTranslations { get; set; }

    }
}
