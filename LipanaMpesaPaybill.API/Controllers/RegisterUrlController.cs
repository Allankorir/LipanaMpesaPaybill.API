using LipanaMpesaPaybill.API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;

namespace LipanaMpesaPaybill.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterUrlController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public RegisterUrlController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public async Task<IActionResult> RegisterUrl()
        {

            var req = new RegisterUrlDto
            {
                ResponseType = _configuration["ReponseType"],
                ShortCode = _configuration["ShortCode"],
                ConfirmationURL = _configuration["ConfirmationURL"],
                ValidationURL = _configuration["ValidationURL"],
            };
            var token= _configuration["Token"];
            var registerUrlEndPoint = _configuration["RegisterUrl"];

            using (var client = new RestClient(registerUrlEndPoint))
            {

                var request = new RestRequest("", Method.Post);

                request.AddHeader("Content-Type", "application/json");

                request.AddHeader("Authorization", $"Token {token}");

                var reqbody = JsonConvert.SerializeObject(req);


                request.AddJsonBody(reqbody);

                request.RequestFormat = DataFormat.Json;

                var res = await client.ExecuteAsync(request);

                return Ok(res);

            }
        }

    }
}
