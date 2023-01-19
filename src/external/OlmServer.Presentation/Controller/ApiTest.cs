using Microsoft.AspNetCore.Mvc;
using OlmServer.Presentation.Abstractions;

namespace OlmServer.Presentation.Controller
{
    public class ApiTest : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}
