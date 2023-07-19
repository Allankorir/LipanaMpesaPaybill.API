using AutoMapper;
using LipanaMpesaPaybill.API.Dtos;

namespace LipanaMpesaPaybill.API.Core.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<PaymentNotificationDto, Transaction>().ReverseMap();
        }
    }
}
