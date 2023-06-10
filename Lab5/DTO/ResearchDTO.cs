
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.DTO
{
    class ResearchDTO
    {
        public CustomerDTO Customer { get; set; }
        public DateTime SigningDate { get; set; }
        public List<PublicationDTO> Publications { get; set; }
    }
}
