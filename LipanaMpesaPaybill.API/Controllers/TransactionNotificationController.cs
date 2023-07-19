using AutoMapper;
using LipanaMpesaPaybill.API.Core;
using LipanaMpesaPaybill.API.Core.Services;
using LipanaMpesaPaybill.API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LipanaMpesaPaybill.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionNotificationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITransactionService _trasactionService;

        public TransactionNotificationController(IMapper mapper,ITransactionService trasactionService)
        {
            _mapper = mapper;

            _trasactionService = trasactionService;
        }
        [HttpPost]
        [Route("ipn")]
        public async Task<IActionResult> ReceivePayment(PaymentNotificationDto paymentNotificationDto)
        {
            var paymentDomain = _mapper.Map<Transaction>(paymentNotificationDto);

            var transaction= await _trasactionService.PostTransactionAsync(paymentDomain);

            if (transaction != null)
            {
                var res = new SuccessReceivePaymentDto
                { 
                    ResultCode="0",
                    ResultDesc="Success"
                
                };

                return Ok(res);

            }

            return StatusCode(500);

        }

    }
}
