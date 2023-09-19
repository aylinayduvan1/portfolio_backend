using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;

    private UserRepository? _userRepository;
    private UserTokenRepository? _userTokenRepository;
    private CommentRepository? _commentRepository;

    private AdvertRepository? _advertRepository;
    private SkillRepository? _skillRepository;
    private EducationRepository? _educationRepository;
    private ExperienceRepository? _experienceRepository;



    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public IUserRepository Users => _userRepository ??= new UserRepository(_postgresContext);
    public IUserTokenRepository UserTokens => _userTokenRepository ??= new UserTokenRepository(_postgresContext);
    public ICommentRepository Comments => _commentRepository ??= new CommentRepository(_postgresContext);
    public IAdvertRepository Adverts => _advertRepository ??= new AdvertRepository(_postgresContext);
    public ISkillRepository Skilles => _skillRepository ??= new SkillRepository(_postgresContext);
    public IEducationRepository Educations => _educationRepository ??= new EducationRepository(_postgresContext);
    public IExperienceRepository Experiences => _experienceRepository ??= new ExperienceRepository(_postgresContext);


    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }

    public void Dispose()
    {
        _postgresContext.Dispose();
    }
}