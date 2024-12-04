namespace MusiKup.Domain.Entities.Files;

public class PerformerFile : BaseFile
{
    public Performer Performer { get; set; }
    public Guid PerformerId { get; set; }
}