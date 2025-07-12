using Mango.Services.ShoppingCartApi.Model.DTO;

namespace Mango.Services.ShoppingCartApi.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDTO> GetCoupon(string couponCode);
    }
}
