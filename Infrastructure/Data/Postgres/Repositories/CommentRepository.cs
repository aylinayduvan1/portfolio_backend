using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class CommentRepository : Repository<Comment, int>, ICommentRepository
    {
        public CommentRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Comment>> GetAdvertByIdAsync(int id)
        {
            return await PostgresContext.Set<Comment>()
                .Where(Comment => Comment.Id == id)
                .ToListAsync();
        }
        public async Task<IList<Comment>> GetAllAsync(Expression<Func<Comment, bool>>? filter = null)
        {
            var Comment = PostgresContext.Set<Comment>();

            return filter == null
                ? await Comment.ToListAsync()
                : await Comment.Where(filter)
                .ToListAsync();
        }

    }
}