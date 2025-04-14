using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;
using Discount.Grpc.Repositories;
using Grpc.Core;

namespace Discount.Grpc.Services
{
    public class DiscountService : DiscountProtoService.DiscountProtoServiceBase
    {
        private readonly IDiscountRepository _repository;
        private readonly IMapper _mapper;
        //private readonly ILogger<DiscountService> _logger;

        public DiscountService(IDiscountRepository discountRepository, IMapper mapper)
        {
            _repository = discountRepository ?? throw new ArgumentNullException(nameof(discountRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public override async Task<CouponModel> GetDiscount(GetDiscountRequest request, ServerCallContext context)
        {
            var coupon = await _repository.GetDiscount(request.ProductName);

            if (coupon == null)
                return new CouponModel { ProductName = "No Discount", Amount = 0, Description = "No Discount Desc" };

            return _mapper.Map<CouponModel>(coupon);
        }
        public override async Task<CouponModel> CreateDiscount(CreateDiscountRequest request, ServerCallContext context)
        {
            var coupon = _mapper.Map<Coupon>(request.Coupon);

            var result = await _repository.CreateDiscount(coupon);

            return result ? _mapper.Map<CouponModel>(coupon)
                : new CouponModel { ProductName = "No Discount", Amount = 0, Description = "No Discount Desc" };
        }
        public override async Task<CouponModel> UpdateDiscount(UpdateDiscountRequest request, ServerCallContext context)
        {
            var coupon = _mapper.Map<Coupon>(request.Coupon);

            var result = await _repository.UpdateDiscount(coupon);

            return result ? _mapper.Map<CouponModel>(coupon)
                : new CouponModel { ProductName = "No Discount", Amount = 0, Description = "No Discount Desc" };
        }
        public override async Task<DeleteDiscountResponse> DeleteDiscount(DeleteDiscountRequest request, ServerCallContext context)
        {
            var result = await _repository.DeleteDiscount(request.ProductName);

            return new DeleteDiscountResponse { Success = result };
        }
    }
}
