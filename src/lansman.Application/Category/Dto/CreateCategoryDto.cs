using Abp.Application.Services.Dto;

namespace lansman.Category.Dto
{
    public class CreateCategoryDto : EntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ImageUrl { get; set; }
    }
}
