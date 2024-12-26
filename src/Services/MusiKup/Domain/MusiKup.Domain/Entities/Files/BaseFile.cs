namespace MusiKup.Domain.Entities.Files;

public class BaseFile : BaseEntity
{
    public string FileName { get; set; }

    public long FileSize { get; set; }

    public string FilePath { get; set; }
    
    public string GoogleName { get; set; }
}