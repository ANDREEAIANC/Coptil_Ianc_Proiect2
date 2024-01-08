using Coptil_Ianc_Proiect2.Models;
namespace Coptil_Ianc_Proiect2;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Programare)BindingContext;
        await App.Database.SaveProgramareAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Programare)BindingContext;
        await App.Database.DeleteProgramareAsync(slist);
        await Navigation.PopAsync();
    }
}