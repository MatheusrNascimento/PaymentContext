
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    
    public class PaypalPayment : Payment
    {
        public PaypalPayment(string transactionCode, DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, Address address, Document document, string payer, Email email): 
        base(paidDate,  expiredDate,  total,  totalPaid,  address,  document,  payer,  email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
