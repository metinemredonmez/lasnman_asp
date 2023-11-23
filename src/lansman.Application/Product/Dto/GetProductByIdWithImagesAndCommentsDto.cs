using Abp.Application.Services.Dto;
using lansman.Comment.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lansman.Product.Dto
{
    public class GetProductByIdWithImagesAndCommentsDto : EntityDto
    {
        public GetProductByIdWithImagesAndCommentsDto()
        {
            ProductImages = new List<CreateProductImageDto>();
            Comments = new List<CreateCommentDto>();
        }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StockCount { get; set; }
        public bool IsDiscount { get; set; }
        public List<CreateProductImageDto> ProductImages { get; set; }
        public List<CreateCommentDto> Comments { get; set; }
    }
}
