using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lansman.Comment.Dto
{
    [AutoMapTo(typeof(CommentImage))]
    public class CreateCommentImageDto : EntityDto
    {
        public byte[] Image { get; set; }
    }
}
