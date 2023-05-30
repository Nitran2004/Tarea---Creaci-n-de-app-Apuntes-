
namespace MZ_Notes.Views;

public partial class MZ_NotePage : ContentPage
{
    
	string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    
    public MZ_NotePage()
	{
        InitializeComponent();

        if (File.Exists(_fileName))
            MZ_TextEditor.Text = File.ReadAllText(_fileName);
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
    }
    
    private void MZ_SaveButton_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, MZ_TextEditor.Text);
        }
    private void MZ_DeleteButton_Clicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
                File.Delete(_fileName);

            MZ_TextEditor.Text = string.Empty;
        }
    private void LoadNote(string fileName)
    {
        Models.Note noteModel = new Models.Note();
        noteModel.Filename = fileName;

        if (File.Exists(fileName))
        {
            noteModel.Date = File.GetCreationTime(fileName);
            noteModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = noteModel;
    }



}
