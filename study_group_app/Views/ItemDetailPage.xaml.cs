using study_group_app.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace study_group_app.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}