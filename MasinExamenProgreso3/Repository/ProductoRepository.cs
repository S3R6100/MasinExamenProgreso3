using SQLite;
using MasinExamenProgreso3.Models;

namespace MasinExamenProgreso3.Data
{
    public class ProductoRepository
    {
        private readonly SQLiteConnection _connection;

        public ProductoRepository(string dbPath)
        {
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<Producto>();
        }

        public int AgregarProducto(Producto producto)
        {
            return _connection.Insert(producto);
        }

        public List<Producto> ObtenerProductos()
        {
            return _connection.Table<Producto>().ToList();
        }
    }
}