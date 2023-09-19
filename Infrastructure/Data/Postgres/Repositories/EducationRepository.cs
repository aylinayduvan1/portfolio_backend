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
    public class EducationRepository : Repository<Education, int>, IEducationRepository
    {
        public EducationRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Education>> GetEducationByIdAsync(int id)
        {
            return await PostgresContext.Set<Education>()
            .Include(Education => Education.Id)
            .Where(Education => Education.Id == id)
                .ToListAsync();
        }
        public async Task<IList<Education>> GetAllAsync(Expression<Func<Education, bool>>? filter = null)
        {
            var Education = PostgresContext.Set<Education>();


            return filter == null
                ? await Education.ToListAsync()
                : await Education.Where(filter)
                .ToListAsync();
        }

    }
}