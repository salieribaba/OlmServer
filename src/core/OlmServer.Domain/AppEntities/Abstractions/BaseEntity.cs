namespace OlmServer.Domain.AppEntities.Abstractions
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; } 
        public DateTime? ModifiedDate { get; set; }
    }
}
