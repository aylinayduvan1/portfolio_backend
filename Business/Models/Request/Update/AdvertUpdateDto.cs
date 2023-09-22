using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class AdvertUpdateDto
    {
        public string Degree { get; set; } = default!;
        public string Fullname { get; set; } = default!;
        public string Advert_text { get; set; } = default!;
    }
}
