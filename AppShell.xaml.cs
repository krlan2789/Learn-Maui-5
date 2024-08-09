using LearnMaui5.Pages;

namespace LearnMaui5
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("addpart", typeof(AddPartPage));
        }
    }
}
