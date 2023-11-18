using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lansman.Product.Dto
{
    [AutoMapTo(typeof(ProductImage))]
    public class CreateProductImageDto : EntityDto
    {
        public byte[] Image { get; set; }
    }
}
