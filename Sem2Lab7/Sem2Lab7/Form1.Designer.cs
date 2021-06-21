namespace Sem2Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateFolders = new System.Windows.Forms.Button();
            this.CreateSubfolders = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SearchAndOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateFolders
            // 
            this.CreateFolders.Location = new System.Drawing.Point(65, 64);
            this.CreateFolders.Name = "CreateFolders";
            this.CreateFolders.Size = new System.Drawing.Size(187, 24);
            this.CreateFolders.TabIndex = 0;
            this.CreateFolders.Text = "Створити 100 директорій";
            this.CreateFolders.UseVisualStyleBackColor = true;
            this.CreateFolders.Click += new System.EventHandler(this.CreateFolders_Click);
            // 
            // CreateSubfolders
            // 
            this.CreateSubfolders.Location = new System.Drawing.Point(65, 118);
            this.CreateSubfolders.Name = "CreateSubfolders";
            this.CreateSubfolders.Size = new System.Drawing.Size(187, 23);
            this.CreateSubfolders.TabIndex = 1;
            this.CreateSubfolders.Text = "Створити вкладені директорії";
            this.CreateSubfolders.UseVisualStyleBackColor = true;
            this.CreateSubfolders.Click += new System.EventHandler(this.CreateSubfolders_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(122, 182);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SearchAndOpen
            // 
            this.SearchAndOpen.Location = new System.Drawing.Point(516, 371);
            this.SearchAndOpen.Name = "SearchAndOpen";
            this.SearchAndOpen.Size = new System.Drawing.Size(246, 51);
            this.SearchAndOpen.TabIndex = 3;
            this.SearchAndOpen.Text = "Знайти та відкрити";
            this.SearchAndOpen.UseVisualStyleBackColor = true;
            this.SearchAndOpen.Click += new System.EventHandler(this.SearchAndOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchAndOpen);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CreateSubfolders);
            this.Controls.Add(this.CreateFolders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateFolders;
        private System.Windows.Forms.Button CreateSubfolders;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button SearchAndOpen;
    }
}

