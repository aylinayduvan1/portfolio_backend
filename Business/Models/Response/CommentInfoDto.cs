using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CommentInfoDto
    {
        public int Id { get; set; }
        public string Comment_userName { get; set; } = default!;
        public string Comment_email { get; set; } = default!;
        public string Comment_content { get; set; } = default!;
    }
}
