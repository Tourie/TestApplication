using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly string _requestUrl = "https://www.cbr.ru/scripts/XML_daily.asp";

        [HttpGet]
        public async Task<IActionResult> Index(DateTime? dateTime)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(_requestUrl + "?date_req=02/03/2002");

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var contentStreamReader = new StreamReader(response.Content.ReadAsStream(), Encoding.GetEncoding("windows-1251"));

            XmlSerializer serializer = new(typeof(RateList));
            try
            {
                using var stream = contentStreamReader;
                var rates = (RateList)serializer.Deserialize(stream);
                return Ok(rates);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
