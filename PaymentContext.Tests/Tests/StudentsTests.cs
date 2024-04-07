using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.Tests;

[TestClass]
public class StudentsTests
{
    [TestMethod]
    public void TestMethod1()
    {
        Studant student = new Studant( new Name("Matheus", "Rodrigues"), new Document("05604307909", EDocumentType.CPF), new Email("srabacaxifurtado@gmail.com"));

        var name = new Name("Test", "Test");

    }
}