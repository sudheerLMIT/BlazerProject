using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProj.Shared.Models
{
   public class Incident
    {
        public int Id { get; set; }

        public long IncidentNumber { get; set; }

        public DateTime IncidentDate { get; set; }

        public string NearestStation { get; set; }

        public int NonEmployeeInjuries { get; set; }

        public int EmployeeInjuries { get; set; }


        public int DamagedEquipment { get; set; }
        public int GradeCrossing { get; set; }
        public string SubmittedBy { get; set; }

        public DateTime SubmittedDate { get; set; }
        public string Status { get; set; }

    }
}
