using AulacLichKham.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulacLichKham.Modules.Entities
{
    public class UploadFile : IEntity
    {
        [PrimaryKey]
        public string? CLSPntPrkID { get; set; }
        public string? FolderName { get; set; }
        public string? FileName { get; set; }
        public string? Image { get; set; }

    }

    public class UploadFileParam : IEntity
    {
        [PrimaryKey]
        public string? CLSPntPrkID { get; set; }
        public string? FolderName { get; set; }
        public string? FileName { get; set; }
        public string? Image { get; set; }
    }
}
