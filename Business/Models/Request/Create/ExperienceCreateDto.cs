using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class ExperienceCreateDto
    {
        public string Company { get; set; } = default!;
        public string Company_experience { get; set; } = default!;
        public string Experience_data { get; set; } = default!;
        public string Experience_skill { get; set; } = default!;
        public string Experience_img { get; set; } = default!;
    }
}
