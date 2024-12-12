using MusiKup.Domain.Validations.Primitives;

namespace MusiKup.Domain.Entities.Files;

public class BaseFile : BaseEntity
{
    public string FileName { get; set; }

    public string GoogleDriveName { get; set; }

    public FileType FileType { get; set; }
}