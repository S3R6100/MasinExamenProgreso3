using MasinExamenProgreso3.Helpers;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

namespace MasinExamenProgreso3.ViewModels
{
    public class LogsViewModel : INotifyPropertyChanged
    {
        private const string LogFileName = "Logs_Masin.txt";

        public ObservableCollection<string> Logs { get; } = new();

        public LogsViewModel()
        {
            CargarLogs();
        }

        public void CargarLogs()
        {
            Logs.Clear();

            string path = FileAccessHelper.GetLocalFilePath(LogFileName);

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    Logs.Add(line);
                }
            }
            else
            {
                Logs.Add("No hay registros en el archivo de logs.");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}