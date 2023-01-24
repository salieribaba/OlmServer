using OlmServer.Domain.AppEntities.Abstractions;

namespace OlmServer.Domain.AppEntities
{
    public sealed class Company : BaseEntity
    {
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxAdministration { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string ServerUserId { get; set; }
        public string ServerPassword { get; set; }
        public string ConnectionString { get; set; }


    }
}
