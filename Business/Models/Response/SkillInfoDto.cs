using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class SkillInfoDto
    {
        public int Id { get; set; }
        public string Skill_name { get; set; } = default!;
        public string Skill_data { get; set; } = default!;

    }
}
