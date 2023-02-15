using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoProj.Shared;
using DemoProj.Shared.Models;

namespace DemoProj.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncidentController : Controller
    {
        private readonly ILogger<IncidentController> _logger;

        public IncidentController(ILogger<IncidentController> logger)
        {
            _logger = logger;
        }

        // GET: IncidentController
        [HttpGet]
        public IEnumerable<Incident> Get()
        {
            List<Incident> incidents = new List<Incident>();
            incidents.Add(new Incident { DamagedEquipment=1, EmployeeInjuries=1, GradeCrossing=1, Id=1, IncidentDate=DateTime.Now.AddDays(-2), IncidentNumber=2367, NearestStation="Hyderabad", NonEmployeeInjuries=1, Status="Closed", SubmittedBy="Sudheer", SubmittedDate= DateTime.Now.AddMonths(-2) });
            incidents.Add(new Incident { DamagedEquipment = 2, EmployeeInjuries = 2, GradeCrossing = 3, Id = 4, IncidentDate = DateTime.Now.AddDays(-3), IncidentNumber = 2564564367, NearestStation = "Banglore", NonEmployeeInjuries = 2, Status = "Closed", SubmittedBy = "Nisha", SubmittedDate = DateTime.Now.AddMonths(-2) });
            return incidents;
        }
    }
}
