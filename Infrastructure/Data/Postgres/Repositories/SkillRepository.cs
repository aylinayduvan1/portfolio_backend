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
    public class SkillRepository : Repository<Skill, int>, ISkillRepository
    {
        public SkillRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Skill>> GetSkillByIdAsync(int id)
        {
            return await PostgresContext.Set<Skill>()
            .Include(Skill => Skill.Id)
            .Where(Skill => Skill.Id == id)
                .ToListAsync();
        }
        public async Task<IList<Skill>> GetAllAsync(Expression<Func<Skill, bool>>? filter = null)
        {
            var Skill = PostgresContext.Set<Skill>();


            return filter == null
                ? await Skill.ToListAsync()
                : await Skill.Where(filter)
                .ToListAsync();
        }

    }
}