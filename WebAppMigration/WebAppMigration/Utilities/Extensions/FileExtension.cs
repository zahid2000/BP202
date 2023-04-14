namespace WebAppMigration.Utilities.Extensions
{
    public static class FileExtension
    {
        public static bool CheckFileType(this IFormFile file, string fileType)
        {
            return file.ContentType.Contains(fileType);
        }
        public static bool CheckFileSize(this IFormFile file, decimal sizeByKb)
        {
            return file.Length / 1024 <= sizeByKb;
        }
        public static async Task<string> SaveFileAsync(this IFormFile file, string root)
        {
            string fileName = Guid.NewGuid() + file.FileName;
            string resultPath = Path.Combine(root, fileName);
            using (FileStream stream=new FileStream(resultPath,FileMode.Create))
            {
                await file.CopyToAsync(stream);

            }
            return fileName;
        }
    }
}
