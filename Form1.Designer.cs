
namespace lab2
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.CheckBox();
            this.NameA = new System.Windows.Forms.CheckBox();
            this.Faculty = new System.Windows.Forms.CheckBox();
            this.Cathedra = new System.Windows.Forms.CheckBox();
            this.Size = new System.Windows.Forms.CheckBox();
            this.DateOfCreating = new System.Windows.Forms.CheckBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.NameComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.CathedraComboBox = new System.Windows.Forms.ComboBox();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.TOHTML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(394, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(580, 372);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(29, 415);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 65);
            this.Search.TabIndex = 1;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(211, 415);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(121, 65);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(29, 29);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(93, 29);
            this.Author.TabIndex = 3;
            this.Author.Text = "Author";
            this.Author.UseVisualStyleBackColor = true;
            // 
            // NameA
            // 
            this.NameA.AutoSize = true;
            this.NameA.Location = new System.Drawing.Point(29, 77);
            this.NameA.Name = "NameA";
            this.NameA.Size = new System.Drawing.Size(85, 29);
            this.NameA.TabIndex = 4;
            this.NameA.Text = "Name";
            this.NameA.UseVisualStyleBackColor = true;
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Location = new System.Drawing.Point(29, 125);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(92, 29);
            this.Faculty.TabIndex = 5;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = true;
            // 
            // Cathedra
            // 
            this.Cathedra.AutoSize = true;
            this.Cathedra.Location = new System.Drawing.Point(29, 178);
            this.Cathedra.Name = "Cathedra";
            this.Cathedra.Size = new System.Drawing.Size(109, 29);
            this.Cathedra.TabIndex = 6;
            this.Cathedra.Text = "Cathedra";
            this.Cathedra.UseVisualStyleBackColor = true;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(29, 225);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(69, 29);
            this.Size.TabIndex = 8;
            this.Size.Text = "Size";
            this.Size.UseVisualStyleBackColor = true;
            // 
            // DateOfCreating
            // 
            this.DateOfCreating.AutoSize = true;
            this.DateOfCreating.Location = new System.Drawing.Point(29, 278);
            this.DateOfCreating.Name = "DateOfCreating";
            this.DateOfCreating.Size = new System.Drawing.Size(165, 29);
            this.DateOfCreating.TabIndex = 9;
            this.DateOfCreating.Text = "Date of creating";
            this.DateOfCreating.UseVisualStyleBackColor = true;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(190, 25);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(182, 33);
            this.AuthorComboBox.Sorted = true;
            this.AuthorComboBox.TabIndex = 10;
            // 
            // NameComboBox
            // 
            this.NameComboBox.FormattingEnabled = true;
            this.NameComboBox.Location = new System.Drawing.Point(190, 73);
            this.NameComboBox.Name = "NameComboBox";
            this.NameComboBox.Size = new System.Drawing.Size(182, 33);
            this.NameComboBox.Sorted = true;
            this.NameComboBox.TabIndex = 11;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(190, 121);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(182, 33);
            this.FacultyComboBox.Sorted = true;
            this.FacultyComboBox.TabIndex = 12;
            // 
            // CathedraComboBox
            // 
            this.CathedraComboBox.FormattingEnabled = true;
            this.CathedraComboBox.Location = new System.Drawing.Point(190, 174);
            this.CathedraComboBox.Name = "CathedraComboBox";
            this.CathedraComboBox.Size = new System.Drawing.Size(182, 33);
            this.CathedraComboBox.Sorted = true;
            this.CathedraComboBox.TabIndex = 13;
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(190, 225);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(182, 33);
            this.SizeComboBox.Sorted = true;
            this.SizeComboBox.TabIndex = 15;
            // 
            // DateComboBox
            // 
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.Location = new System.Drawing.Point(190, 278);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(182, 33);
            this.DateComboBox.Sorted = true;
            this.DateComboBox.TabIndex = 16;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(29, 368);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(70, 29);
            this.SAX.TabIndex = 17;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(121, 368);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(80, 29);
            this.DOM.TabIndex = 18;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(211, 368);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(77, 29);
            this.LINQ.TabIndex = 19;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // TOHTML
            // 
            this.TOHTML.Location = new System.Drawing.Point(380, 415);
            this.TOHTML.Name = "TOHTML";
            this.TOHTML.Size = new System.Drawing.Size(121, 65);
            this.TOHTML.TabIndex = 20;
            this.TOHTML.Text = "TO HTML";
            this.TOHTML.UseVisualStyleBackColor = true;
            this.TOHTML.Click += new System.EventHandler(this.TOHTML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 503);
            this.Controls.Add(this.TOHTML);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.CathedraComboBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.NameComboBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.DateOfCreating);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Cathedra);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.NameA);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Лабораторна робота 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.CheckBox Author;
        private System.Windows.Forms.CheckBox NameA;
        private System.Windows.Forms.CheckBox Faculty;
        private System.Windows.Forms.CheckBox Cathedra;
        private System.Windows.Forms.CheckBox Size;
        private System.Windows.Forms.CheckBox DateOfCreating;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.ComboBox NameComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.ComboBox CathedraComboBox;
        private System.Windows.Forms.ComboBox SizeComboBox;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.Button TOHTML;
    }
}

