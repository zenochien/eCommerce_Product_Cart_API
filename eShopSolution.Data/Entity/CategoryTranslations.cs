using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class CategoryTranslations
    {
        public int Id { get; set; }
        public int CalegoryId { get; set; }
        public string Name { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public string LanguageId { set; get; }
        public string SeoAlias { get; set; }
        public Category Category { get; set; }
        public Language Language { get; set; }

    }
}
