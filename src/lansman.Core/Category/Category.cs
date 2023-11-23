using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace lansman.Category
{
    public class Category : Entity, IHasCreationTime, IHasModificationTime, ISoftDelete
    {
        public Category()
        {
            Products = new List<Product.Product>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }
        public List<Product.Product> Products { get; set; }
    }
}
