using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class EducationCreateDto
    {
        public string School_name { get; set; } = default!;
        public string Graduation_data { get; set; } = default!;
        public string Education_text { get; set; } = default!;
    }
}
