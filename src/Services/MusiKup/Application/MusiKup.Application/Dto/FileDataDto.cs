namespace MusiKup.Application.Dto;

public record FileDataDto(string FileName, Stream Stream, string FileContent);