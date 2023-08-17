using Aulac.Service.Rsc.Tags;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace AulacLichKham.Controllers
{

    [Tags("Version")]
    [Route("version")]
    public class UpdateVersionController : Controller
    {
        private readonly ILogger<UpdateVersionController> _logger;
        public UpdateVersionController(ILogger<UpdateVersionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("update-version")]
        public byte[] UpdateVersion(string version)
        {
            try
            {
                string currentDirectory = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("appSettings")["CurrentDirectory"];
                // string currentDirectory = _configuration[ConfigKey.CurrentDirectory];
                _logger.LogInformation(currentDirectory);
                DirectoryInfo dirInfo = null;
                if (currentDirectory != "")
                {
                    string directoryPath = Path.Combine(currentDirectory, tagUpdateVersion.DirectoryUpdate);
                    dirInfo = new DirectoryInfo(directoryPath);

                }
                else
                {
                    string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), tagUpdateVersion.DirectoryUpdate);
                    dirInfo = new DirectoryInfo(directoryPath);
                }

                DirectoryInfo[] childDirs = dirInfo.GetDirectories();

                string path = "";
                string fileName = "";

                foreach (DirectoryInfo childDir in childDirs)
                {
                    if (Int64.Parse(childDir.Name.Replace(".", "").ToString()) > Int64.Parse(version.Replace(".", "").ToString()))
                    {
                        path = childDir.FullName;
                        FileInfo[] childFiles = childDir.GetFiles();

                        foreach (FileInfo childFile in childFiles)
                        {
                            if (childFile.Name.Contains(tagUpdateVersion.FullFileNameUpdate))
                            {
                                fileName = childFile.Name;
                                break;
                            }
                        }

                        break;
                    }
                }

                if (System.IO.File.Exists(Path.Combine(path, fileName)))
                {
                    // Open and read a file
                    FileStream fileStream = System.IO.File.OpenRead(Path.Combine(path, fileName));
                    int b1;
                    System.IO.MemoryStream tempStream = new MemoryStream();
                    while ((b1 = fileStream.ReadByte()) != -1)
                    {
                        tempStream.WriteByte(((byte)b1));
                    }
                    fileStream.Close();
                    return tempStream.ToArray();
                }
                else
                {
                    return new byte[0];
                }
            }
            catch (Exception ex)
            {
                if (_logger.IsEnabled(LogLevel.Error))
                {
                    _logger.LogError(ex, ex.Message);
                }

                return new byte[0];
            }
        }

        [HttpGet("check-update-version")]
        public string CheckUpdateVersion(string version)
        {
            try
            {
                string currentDirectory = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("appSettings")["CurrentDirectory"];
                // string currentDirectory = _configuration[ConfigKey.CurrentDirectory];
                _logger.LogInformation(currentDirectory);
                DirectoryInfo dirInfo = null;
                if (currentDirectory != "")
                {
                    string directoryPath = Path.Combine(currentDirectory, tagUpdateVersion.DirectoryUpdate);
                    dirInfo = new DirectoryInfo(directoryPath);

                }
                else
                {
                    string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), tagUpdateVersion.DirectoryUpdate);
                    dirInfo = new DirectoryInfo(directoryPath);
                }

                DirectoryInfo[] childDirs = dirInfo.GetDirectories();

                string path = "";
                string fileName = "";

                foreach (DirectoryInfo childDir in childDirs)
                {
                    if (Int64.Parse(childDir.Name.Replace(".", "").ToString()) > Int64.Parse(version.Replace(".", "").ToString()))
                    {
                        path = childDir.FullName;
                        FileInfo[] childFiles = childDir.GetFiles();

                        foreach (FileInfo childFile in childFiles)
                        {
                            if (childFile.Name.Contains(tagUpdateVersion.FullFileNameUpdate))
                            {
                                fileName = childFile.Name;
                                break;
                            }
                        }

                        break;
                    }
                }

                if (System.IO.File.Exists(Path.Combine(path, fileName)))
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
            }
            catch (Exception ex)
            {
                if (_logger.IsEnabled(LogLevel.Error))
                {
                    _logger.LogError(ex, ex.Message);
                }

                return "0";
            }
        }
    }
}
