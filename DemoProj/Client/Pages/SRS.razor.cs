using Microsoft.AspNetCore.Components;
using DemoProj.Shared.Models;
using DemoProj.Shared;
using System.Net.Http.Json;

namespace DemoProj.Client.Pages
{
    public partial  class SRS : ComponentBase
    {
        public string search { get; set; }

       public IEnumerable<Incident> incidents { get; set; }
        protected override async Task OnInitializedAsync()
        {
            incidents = new  List<Incident>();
            incidents = await Http.GetFromJsonAsync<Incident[]>("Incident");
        }






    }
}
