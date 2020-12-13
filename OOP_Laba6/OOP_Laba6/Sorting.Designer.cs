
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
            this.type_sort = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.TextBox();
            this.count = new System.Windows.Forms.TextBox();
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
            // type_sort
            // 
            this.type_sort.AutoSize = true;
            this.type_sort.Font = new System.Drawing.Font("JetBrains Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_sort.Location = new System.Drawing.Point(99, 19);
            this.type_sort.Name = "type_sort";
            this.type_sort.Size = new System.Drawing.Size(223, 29);
            this.type_sort.TabIndex = 5;
            this.type_sort.Text = "Тип сортировки:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(161, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Go_MouseClick);
            // 
            // file_name
            // 
            this.file_name.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_name.ForeColor = System.Drawing.Color.Gray;
            this.file_name.Location = new System.Drawing.Point(21, 138);
            this.file_name.Multiline = true;
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(229, 43);
            this.file_name.TabIndex = 14;
            this.file_name.Text = "File name";
            this.file_name.Enter += new System.EventHandler(this.file_name_Enter);
            this.file_name.Leave += new System.EventHandler(this.file_name_Leave);
            // 
            // count
            // 
            this.count.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.ForeColor = System.Drawing.Color.Gray;
            this.count.Location = new System.Drawing.Point(293, 137);
            this.count.Multiline = true;
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(129, 43);
            this.count.TabIndex = 15;
            this.count.Text = "Count";
            this.count.Enter += new System.EventHandler(this.count_Enter);
            this.count.Leave += new System.EventHandler(this.count_Leave);
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
            this.Controls.Add(this.count);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.type_sort);
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
        private System.Windows.Forms.Label type_sort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox file_name;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.RadioButton Quick;
        private System.Windows.Forms.RadioButton Choice;
    }
}