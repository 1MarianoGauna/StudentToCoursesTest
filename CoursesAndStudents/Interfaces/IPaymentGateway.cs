namespace CoursesAndStudents.Interfaces
{
    public interface IPaymentGateway
    {
        bool ProcessPayment(decimal amount, string creditCardNumber, string cardHolderName, string expirationDate, string cvv);

    }
}
