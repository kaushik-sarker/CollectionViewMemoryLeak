using CollectionViewMemoryLeak.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewMemoryLeak
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        UserViewModel viewModel;
        public MainPage(UserViewModel userViewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel = userViewModel;
        }

        private void OnClicked(object sender, EventArgs e)
        {
            viewModel.LoadData();
        }
    }

}
