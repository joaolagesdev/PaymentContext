using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    // Abstração, não implementamos
    // Implementação na infraestrutura, que será abordada em outro curso
    public interface IStudentRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string email);
        void CreateSubscription(Student student);
    }
}