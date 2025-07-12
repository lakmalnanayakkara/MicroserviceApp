namespace Mango.Services.ShoppingCartApi.Model.DTO
{
    public class ResponseDTO
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = ""; 
    }
}
