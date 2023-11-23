using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lansman.Comment.Dto
{
    [AutoMapTo(typeof(Comment))]
    public class CreateCommentDto : EntityDto
    {
        public CreateCommentDto()
        {
            CommentImages = new List<CreateCommentImageDto>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<CreateCommentImageDto> CommentImages { get; set; }
    }
}
