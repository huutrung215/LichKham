using AulacLichKham.Modules.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Repositories
{
    public class FileRepository : IFileRepository
    {
        private readonly string _uploadDirectory;

        public FileRepository(string uploadDirectory)
        {
            _uploadDirectory = uploadDirectory;
        }

        public void SaveFile(string directoryPath, string fileName, byte[] fileBytes)
        {
            string uploadPath = Path.Combine(_uploadDirectory, directoryPath);
            string filePath = Path.Combine(uploadPath, fileName);

            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            File.WriteAllBytes(filePath, fileBytes);
        }
    }
}
