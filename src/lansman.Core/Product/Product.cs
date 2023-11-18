using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace lansman.Product
{
    public class Product : Entity, IHasCreationTime, IHasModificationTime, ISoftDelete
    {
        public Product()
        {
            ProductImages = new List<ProductImage>();
        }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsDiscount { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }
        public Category.Category Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }

    }
}
