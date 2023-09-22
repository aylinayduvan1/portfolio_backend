using Business.Models.Request;
using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()

        //user
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, UserProfileDto>();
        CreateMap<UserUpdateDto, User>();

        //advert 
        CreateMap<Advert, AdvertInfoDto>();
        CreateMap<AdvertUpdateDto, Advert>();
        CreateMap<AdvertCreateDto, Advert>();


        //comment
        CreateMap<Comment, CommentInfoDto>();
        CreateMap<CommentUpdateDto, Comment>();
        CreateMap<CommentCreateDto, Comment>();

        //education
        CreateMap<Education, EducationInfoDto>();
        CreateMap<EducationUpdateDto, Education>();
        CreateMap<EducationCreateDto, Education>();

        //experience 
        CreateMap<Experience, ExperienceInfoDto>();
        CreateMap<ExperienceUpdateDto, Experience>();
        CreateMap<ExperienceCreateDto, Experience>();

        //skill
        CreateMap<Skill, SkillInfoDto>();
        CreateMap<SkillUpdateDto, Skill>();
        CreateMap<SkillCreateDto, Skill>();

    }
}