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
    public class ExperienceRepository : Repository<Experience, int>, IExperienceRepository
    {
        public ExperienceRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Experience>> GetExperienceByIdAsync(int id)
        {
            return await PostgresContext.Set<Experience>()
            .Include(Experience => Experience.Id)
            .Where(Experience => Experience.Id == id)
                .ToListAsync();
        }
        public async Task<IList<Experience>> GetAllAsync(Expression<Func<Experience, bool>>? filter = null)
        {
            var Experience = PostgresContext.Set<Experience>();
          

            return filter == null
                ? await Experience.ToListAsync()
                : await Experience.Where(filter)
                .ToListAsync();
        }

    }
}