using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    ICommentRepository Comments { get; }
    IAdvertRepository Adverties { get; }
    IEducationRepository Educations { get; }
    IExperienceRepository Experiences { get; }
    ISkillRepository Skilles { get; }


    Task<int> CommitAsync();
}