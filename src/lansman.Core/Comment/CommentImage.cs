using Abp.Domain.Entities;

namespace lansman.Comment
{
    public class CommentImage : Entity
    {
        public int CommentId { get; set; }
        public byte[] Image { get; set; }
        public Comment Comment { get; set; }
    }
}
