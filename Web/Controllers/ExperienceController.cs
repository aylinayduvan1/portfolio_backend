using Business.Models.Request;
using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories;
using Web.Controllers.Base;

namespace Web.Controllers;

public class ExperienceController : BaseCRUDController<Experience, int, ExperienceCreateDto, ExperienceUpdateDto, ExperienceInfoDto>
{
    public ExperienceController(IExperienceService service) : base(service)
    {
    }
}