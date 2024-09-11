using AulaMVVMHTTPClient.ViewModels;

namespace AulaMVVMHTTPClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            BindingContext = new PostViewModel();
            InitializeComponent();
        }
    }
}
