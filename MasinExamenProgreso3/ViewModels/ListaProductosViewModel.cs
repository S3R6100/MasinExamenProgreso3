using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MasinExamenProgreso3.Models;

namespace MasinExamenProgreso3.ViewModels
{
    public class ListaProductosViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Producto> Productos { get; set; } = new();

        public ICommand CargarCommand { get; }

        public ListaProductosViewModel()
        {
            CargarCommand = new Command(CargarProductos);
            CargarProductos();
        }

        private void CargarProductos()
        {
            Productos.Clear();
            var lista = App.ProductoRepo.ObtenerProductos();

            foreach (var prod in lista)
                Productos.Add(prod);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}