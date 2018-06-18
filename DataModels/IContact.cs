using System;

namespace Xynaps.Api.Models
{
    public interface IContact
    {
        Address Address { get; set; }
        CollaborationSettings CollaborationSettings { get; set; }
        string EmailAddress { get; set; }
        string ExternalId { get; set; }
        long? Id { get; set; }
        string MobileNumber { get; set; }
        string Name { get; set; }
        string OrganizationNumber { get; set; }
        DateTime? SignatureDate { get; set; }
        string SignatureImage { get; set; }
        string SignatureName { get; set; }
        string SignatureText { get; set; }
        string TelephoneNumber { get; set; }
        string Text { get; set; }
    }
}