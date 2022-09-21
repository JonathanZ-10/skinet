using Core.Entities.OrderAggregate;
using Core.Specification;

namespace Core.Specifications
{
    public class OrderByPaymentIntentsSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentsSpecification(string paymentIntentId) 
            : base(o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}