using Abp.Domain.Entities;

namespace lansman.Product
{
    public class ProductImage : Entity, ISoftDelete
    {
        public int ProductId { get; set; }
        public  byte[] Image { get; set; }
        public bool IsDeleted { get; set; }
        public Product Product { get; set; }
    }
}
