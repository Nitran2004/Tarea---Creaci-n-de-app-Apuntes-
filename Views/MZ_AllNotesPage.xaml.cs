

namespace MZ_Notes.Views;

public partial class MZ_AllNotesPage : ContentPage
{
    public MZ_AllNotesPage()
    {
        InitializeComponent();
        BindingContext = new Models.AllNotes();


    }

    public string NotePage { get; private set; }

    protected override void OnAppearing()
    {
        ((Models.AllNotes)BindingContext).LoadNotes();

    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NotePage));

    }

    private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var note = (Models.Note)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            await Shell.Current.GoToAsync($"{nameof(NotePage)}?{nameof(NotePage.ItemId)}={note.Filename}");

            // Unselect the UI
            notesCollection.SelectedItem = null;


        }
    }

  
}