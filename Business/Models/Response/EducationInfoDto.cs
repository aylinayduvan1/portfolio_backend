using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class EducationInfoDto
    {
        public int Id { get; set; }
        public string School_name { get; set; } = default!;
        public string Graduation_data { get; set; } = default!;
        public string Education_text { get; set; } = default!;

    }
}
