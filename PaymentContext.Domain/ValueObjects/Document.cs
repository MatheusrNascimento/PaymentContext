
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObjet
    {
        public Document(string document, EDocumentType type)
        {
            Number = document;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; set; }
    }
}