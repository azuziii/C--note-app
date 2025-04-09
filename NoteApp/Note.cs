using System.Net.Http.Headers;

namespace NoteApp
{
    public class Note(string title, string content, int? id = null)
    {
        private string _title = title;
        private string _content = content;
        private readonly int _id = id is null ? new Random().Next() : (int)id;

        public string Title
        {
            set => _title = value;
            get => _title;
        }

        public string Content
        {
            set => _content = value;
            get => _content;
        }

        public int Id
        {
            get => _id;
        }
    }
}