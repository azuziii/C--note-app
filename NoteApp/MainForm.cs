namespace NoteApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            notesList.DisplayMember = "Title";
            notesList.ValueMember = "Id";
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new();
            addForm.FormClosed += AddForm_FormClosed;
            addForm.Show();


        }

        private void AddForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            DataService ds = DataService.Instance;

            notesList.Items.Clear();

            ds.notes.ForEach(note =>
            {
                Item item = new(note.Title, note.Id);
                notesList.Items.Add(item);
            });
        }

        private void editNoteButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItem is not Item item)
            {
                MessageBox.Show("Please select a note first.");
                return;
            }
            ;

            DataService ds = DataService.Instance;

            Note? note = ds.getById(item.Id);

            if (note is null)
            {
                MessageBox.Show("Failed to edit note, please restart app.");
                return;
            }

            AddForm addForm = new(note);
            addForm.FormClosed += AddForm_FormClosed;
            addForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (notesList.SelectedItem is not Item item)
            {
                MessageBox.Show("Please select a note to delete.");
                return;
            }
            ;

            DataService ds = DataService.Instance;

            Note? note = ds.getById(item.Id);

            if (note is null)
            {
                MessageBox.Show("Failed to delete note, please restart app.");
                return;
            }

            ds.deleteNote(note);

            notesList.Items.Remove(item);
        }
    }
}
