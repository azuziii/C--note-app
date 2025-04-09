using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    internal class DataService
    {

        static DataService? instance = null;

        public static DataService Instance
        {
            get {
                return instance ??= new DataService();
            }
        }

        public List<Note> notes = [];

        public void addNote(Note note)
        {
            notes.Add(note);
        }

        public Note? getById(int id)
        {
            return notes.FirstOrDefault(n => n.Id == id);
        }

        public void updateNote(Note oldNote)
        {

            for (int i = 0; i < notes.Count; i++) {
                Note note = notes[i];

                if (note.Id == oldNote.Id)
                {
                    note.Title = oldNote.Title;
                    note.Content = oldNote.Content;
                    break;
                }
            }
        }

        public void deleteNote(Note note) {
            notes.Remove(note);
        }
    }
}
