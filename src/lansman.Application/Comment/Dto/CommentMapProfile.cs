using AutoMapper;
using System.Collections.Generic;

namespace lansman.Comment.Dto
{
    public class CommentMapProfile : Profile
    {
        public CommentMapProfile()
        {

            CreateMap<CreateCommentDto, Comment>()
            .ForMember(dest => dest.CommentImages, opt => opt.MapFrom(src => src.CommentImages))
            .ReverseMap();

            CreateMap<CreateCommentImageDto, CommentImage>()
                .ReverseMap();
        }
    }
}
