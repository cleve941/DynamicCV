using DynamicCV.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DynamicCV.Pages
{
    public partial class Blogs
    {
        [Inject]
        public HttpClient? Http { get; set; }
        private Blog[]? blogs;

        protected override async Task OnInitializedAsync()
        {
            if(Http != null)
            {
                blogs = await Http.GetFromJsonAsync<Blog[]>("sample-data/blogs.json");
            }
            
        }
    }
}
