using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WebApiCoronavirus.Models;

namespace WebApiCoronavirus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronavirusController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CoronavirusController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: api/Coronavirus
        [HttpGet]
        public async  Task<ActionResult<EstadisticasCoVid19>> Get()
        {

            string urlApi = _configuration["ApiCoronaVirus:Url"];

            HttpClient client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(urlApi)
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseBodyJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);


            EstadisticasCoVid19 estadisticas = JsonConvert.DeserializeObject<EstadisticasCoVid19>(responseBodyJson);


            return estadisticas;
        }

        // GET: api/Coronavirus/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Coronavirus
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Coronavirus/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
