namespace MasinExamenProgreso3.Data
{
    public class LogService
    {
        private readonly string _logFilePath;

        public LogService(string apellido)
        {
            string fileName = $"Logs_{apellido}.txt";
            _logFilePath = Path.Combine(FileSystem.AppDataDirectory, fileName);
        }

        public void EscribirLog(string nombreProducto)
        {
            string log = $"Se incluyó el registro [{nombreProducto}] el {DateTime.Now:dd/MM/yyyy HH:mm}";
            File.AppendAllText(_logFilePath, log + Environment.NewLine);
        }

        public List<string> ObtenerLogs()
        {
            if (!File.Exists(_logFilePath))
                return new List<string>();

            return File.ReadAllLines(_logFilePath).ToList();
        }
    }
}