namespace NoteApp
{
    public partial class AddForm : Form
    {

        readonly int? id;
        public AddForm(Note? note = null)
        {
            InitializeComponent();
            display(note);

            if (note is not null) id = note.Id;
        }

        private void display(Note? note)
        {
            if (note is null) return;

                titleText.Text = note.Title;
                contentText.Text = note.Content;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string title = titleText.Text;
            string content = contentText.Text;

            DataService ds = DataService.Instance;

            if (id is null)
            {
                Note newNote = new(title, content);
                ds.addNote(newNote);
            }
            else
            {
                ds.updateNote(new Note(title, content, (int)id));
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
