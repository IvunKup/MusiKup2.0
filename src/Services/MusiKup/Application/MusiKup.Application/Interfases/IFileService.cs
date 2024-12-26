using MusiKup.Application.Dto;

namespace MusiKup.Application.Interfases;

public interface IFileService
{
    Task<string> UploadFileAsync(FileDataDto fileData, CancellationToken cancellationToken = default);

    public Task DeleteFileAsync(string id, CancellationToken cancellationToken = default);

    public Task<FileDataDto> DownloadFileAsync(string id, string originalNam, CancellationToken cancellationToken = default);
}