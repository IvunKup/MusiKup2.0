namespace MusiKup.Application.Dto.Request.PerformerFile;

public record PerformerFileCreateRequest(Guid PerformerId, FileDataDto FileData);