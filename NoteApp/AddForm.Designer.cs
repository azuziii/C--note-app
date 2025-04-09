namespace NoteApp
{
    partial class AddForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            titleText = new TextBox();
            contentLabel = new Label();
            contentText = new RichTextBox();
            saveButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // titleText
            // 
            titleText.Location = new Point(12, 44);
            titleText.Name = "titleText";
            titleText.Size = new Size(360, 39);
            titleText.TabIndex = 1;
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new Point(12, 110);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(100, 32);
            contentLabel.TabIndex = 2;
            contentLabel.Text = "Content";
            // 
            // contentText
            // 
            contentText.Location = new Point(12, 145);
            contentText.Name = "contentText";
            contentText.Size = new Size(360, 202);
            contentText.TabIndex = 3;
            contentText.Text = "";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 381);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(135, 39);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(237, 381);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(135, 39);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 91);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(contentText);
            Controls.Add(contentLabel);
            Controls.Add(titleText);
            Controls.Add(titleLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "AddForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox titleText;
        private Label contentLabel;
        private RichTextBox contentText;
        private Button saveButton;
        private Button cancelButton;
        private Label label1;
    }
}
