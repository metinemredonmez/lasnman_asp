using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using lansman.Authorization.Users;
using lansman.Product;

namespace lansman.Users.Dto
{
    [AutoMapTo(typeof(UserAddress))]
    public class CreateUserAddressDto : EntityDto
    {
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public string FlatNo { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
    }
}
