
namespace OOP_Laba6
{
    partial class Sorting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorting));
            this.Exit = new System.Windows.Forms.Button();
            this.Type_sort = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.File_name = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Quick = new System.Windows.Forms.RadioButton();
            this.Choice = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Black;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(-7, 269);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(448, 30);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseClick);
            // 
            // Type_sort
            // 
            this.Type_sort.AutoSize = true;
            this.Type_sort.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type_sort.Location = new System.Drawing.Point(99, 19);
            this.Type_sort.Name = "Type_sort";
            this.Type_sort.Size = new System.Drawing.Size(223, 29);
            this.Type_sort.TabIndex = 5;
            this.Type_sort.Text = "Тип сортировки:";
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Black;
            this.Go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Go.FlatAppearance.BorderSize = 0;
            this.Go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Go.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Go.ForeColor = System.Drawing.Color.White;
            this.Go.Location = new System.Drawing.Point(161, 204);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(109, 45);
            this.Go.TabIndex = 9;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Go_MouseClick);
            // 
            // File_name
            // 
            this.File_name.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.File_name.ForeColor = System.Drawing.Color.Gray;
            this.File_name.Location = new System.Drawing.Point(21, 138);
            this.File_name.Multiline = true;
            this.File_name.Name = "File_name";
            this.File_name.Size = new System.Drawing.Size(229, 43);
            this.File_name.TabIndex = 14;
            this.File_name.Text = "File name";
            this.File_name.Enter += new System.EventHandler(this.file_name_Enter);
            this.File_name.Leave += new System.EventHandler(this.file_name_Leave);
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.Color.Gray;
            this.Count.Location = new System.Drawing.Point(293, 137);
            this.Count.Multiline = true;
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(129, 43);
            this.Count.TabIndex = 15;
            this.Count.Text = "Count";
            this.Count.Enter += new System.EventHandler(this.count_Enter);
            this.Count.Leave += new System.EventHandler(this.count_Leave);
            // 
            // Quick
            // 
            this.Quick.AutoSize = true;
            this.Quick.Checked = true;
            this.Quick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quick.Font = new System.Drawing.Font("JetBrains Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quick.Location = new System.Drawing.Point(21, 70);
            this.Quick.Name = "Quick";
            this.Quick.Size = new System.Drawing.Size(113, 37);
            this.Quick.TabIndex = 3;
            this.Quick.TabStop = true;
            this.Quick.Text = "Quick";
            this.Quick.UseVisualStyleBackColor = true;
            // 
            // Choice
            // 
            this.Choice.AutoSize = true;
            this.Choice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Choice.Font = new System.Drawing.Font("JetBrains Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choice.Location = new System.Drawing.Point(293, 70);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(129, 37);
            this.Choice.TabIndex = 4;
            this.Choice.Text = "Choice";
            this.Choice.UseVisualStyleBackColor = true;
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.Quick);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.File_name);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.Type_sort);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sorting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sorting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sorting_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Type_sort;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox File_name;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.RadioButton Quick;
        private System.Windows.Forms.RadioButton Choice;
    }
}