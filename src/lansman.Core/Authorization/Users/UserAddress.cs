using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace lansman.Authorization.Users
{
    public class UserAddress : Entity, ISoftDelete, IHasCreationTime, IHasModificationTime
    {
        public long UserId { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string BuildingNo { get; set; }
        public string FlatNo { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public DateTime CreationTime { get; set; }
        public User User { get; set; }
    }
}
