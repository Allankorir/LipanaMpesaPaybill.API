namespace LipanaMpesaPaybill.API.Dtos
{
    public class RegisterUrlDto
    {
        public string ShortCode { get; set; }
        public string ResponseType { get; set; }
        public string ConfirmationURL { get; set; }
        public string ValidationURL { get; set; }
    }
}
