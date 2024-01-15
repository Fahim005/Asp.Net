using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CityCorporationDTO
    {
        public int Id { get; set; }
        public string Information { get; set; }
        public Nullable<int> Hos_info { get; set; }
        public Nullable<int> Child_info { get; set; }
    }
}
