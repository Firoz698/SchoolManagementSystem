namespace SchoolManagementSystem.Data.Entities
{
    public class BlobFile : IEntity
    {
        public int Id { get; set; }
        public Guid GuId { get; set; }
        public string FileName { get; set; }
        public byte[] ImageFile { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}
