using System;
using System.IO;

namespace cmzz
{
    public static class DatabaseConfig
    {
        private static string? _connectionString;

        public static string ConnectionString
        {
            get
            {
                if (_connectionString == null)
                {
                    _connectionString = BuildConnectionString();
                }
                return _connectionString;
            }
        }

        private static string BuildConnectionString()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", baseDir);

            // 1. Check if logincm.mdf exists in the application base directory (bin\Debug\...)
            string mdfPath = Path.Combine(baseDir, "logincm.mdf");

            // 2. If not found in output directory, fallback to project directory
            if (!File.Exists(mdfPath))
            {
                string projectMdf = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\logincm.mdf"));
                if (File.Exists(projectMdf))
                {
                    mdfPath = projectMdf;
                }
            }

            return $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={mdfPath};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        }
    }
}
