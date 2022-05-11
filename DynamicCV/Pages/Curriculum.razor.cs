using DynamicCV.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DynamicCV.Pages
{
    public partial class Curriculum
    {
        [Inject]
        public HttpClient Http { get; set;}
        private Person? person;

        protected override async Task OnInitializedAsync()
        {
            person = await Http.GetFromJsonAsync<Person>("sample-data/person.json");
        }

    }
}
