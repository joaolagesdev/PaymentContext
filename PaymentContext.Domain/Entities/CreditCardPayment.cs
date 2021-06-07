using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            string cardHolderName, 
            string cardNumber, 
            string lastTransaction,  
            DateTime paidDate, 
            DateTime expireDate, 
            decimal total, 
            decimal totalPaid, 
            string payer, 
            Document document, 
            Email email, 
            Address address):base(
                paidDate, 
                expireDate, 
                total, 
                totalPaid, 
                payer, 
                document, 
                email, 
                address)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransaction = lastTransaction;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; } // 4 números, não armazene o código de verificação, data de vencimento, etc.
        public string LastTransaction { get; private set; }
    }
}