namespace AuthServiceIN6BM.Application.Interfaces;

public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string filename);
    Task<bool> DeleteImageAsyn(string publicId);
    string GetDefaultAvantarUrl();
    string GetFullImageUrl(string imagePath);
}