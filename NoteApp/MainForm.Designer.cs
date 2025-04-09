namespace NoteApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            notesList = new ListBox();
            newNoteButton = new Button();
            editNoteButton = new Button();
            deleteButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(notesList);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Notes";
            // 
            // notesList
            // 
            notesList.FormattingEnabled = true;
            notesList.ItemHeight = 15;
            notesList.Location = new Point(6, 22);
            notesList.Name = "notesList";
            notesList.Size = new Size(304, 394);
            notesList.TabIndex = 1;
            // 
            // newNoteButton
            // 
            newNoteButton.Location = new Point(343, 34);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.Size = new Size(75, 23);
            newNoteButton.TabIndex = 1;
            newNoteButton.Text = "New";
            newNoteButton.UseVisualStyleBackColor = true;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // editNoteButton
            // 
            editNoteButton.Location = new Point(343, 63);
            editNoteButton.Name = "editNoteButton";
            editNoteButton.Size = new Size(75, 23);
            editNoteButton.TabIndex = 2;
            editNoteButton.Text = "Edit";
            editNoteButton.UseVisualStyleBackColor = true;
            editNoteButton.Click += editNoteButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(343, 92);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(deleteButton);
            Controls.Add(editNoteButton);
            Controls.Add(newNoteButton);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox notesList;
        private Button newNoteButton;
        private Button editNoteButton;
        private Button deleteButton;
    }
}