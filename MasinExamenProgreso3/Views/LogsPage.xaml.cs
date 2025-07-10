using MasinExamenProgreso3.ViewModels;

namespace MasinExamenProgreso3.Views;

public partial class LogsPage : ContentPage
{
    private LogsViewModel vm;

    public LogsPage()
    {
        InitializeComponent();
        vm = BindingContext as LogsViewModel;
    }

    private void OnRefreshClicked(object sender, EventArgs e)
    {
        vm.CargarLogs();
    }
}