using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using lansman.Authorization.Users;
using System;
using System.Collections.Generic;

namespace lansman.Comment
{
    public class Comment : Entity, IHasCreationTime, IHasModificationTime, ISoftDelete
    {
        public Comment()
        {
            CommentImages = new List<CommentImage>();
        }
        public long UserId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public DateTime? LastModificationTime { get; set; }
        public bool IsDeleted { get; set; }
        public User User { get; set; }
        public Product.Product Product { get; set; }
        public List<CommentImage> CommentImages { get; set; }
    }
}
