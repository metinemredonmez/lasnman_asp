using Abp.Application.Services;
using lansman.Product.Dto;
using lansman.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lansman.Comment.Dto;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;

namespace lansman.Comment
{
    public class CommentAppService : AsyncCrudAppService<Comment, CreateCommentDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, int> repository) : base(repository)
        {
        }
        public override Task<PagedResultDto<CreateCommentDto>> GetAllAsync(PagedAndSortedResultRequestDto input)
        {
            CheckGetAllPermission();

            var list = new List<Comment>();
            var query = Repository.GetAllIncluding(x => x.CommentImages);

            query = ApplySorting(query, input);

            list = query.Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToList();

            var result = new PagedResultDto<CreateCommentDto>(query.Count(), ObjectMapper.Map<List<CreateCommentDto>>(list));
            return Task.FromResult(result);
        }
    }
}
