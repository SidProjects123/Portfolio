using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject_Model.DomainModel
{
    public class Team
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Designation { get; set; }

        public byte[]? TeamImg { get; set; }

        public string? TwitterURL { get; set; }

        public string? FacebookURL { get; set; }

        public string? LinkedInURL { get; set; }
    }
}
