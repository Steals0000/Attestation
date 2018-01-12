namespace _6._1._13
{
    partial class Form
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
            this.StartButton = new System.Windows.Forms.Button();
            this.LabelOut = new System.Windows.Forms.Label();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.LabelCount = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(116, 235);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(234, 74);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Вывести палиндромы";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LabelOut
            // 
            this.LabelOut.AutoSize = true;
            this.LabelOut.Location = new System.Drawing.Point(12, 101);
            this.LabelOut.Name = "LabelOut";
            this.LabelOut.Size = new System.Drawing.Size(13, 20);
            this.LabelOut.TabIndex = 1;
            this.LabelOut.Text = " ";
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(12, 51);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(434, 26);
            this.TextInput.TabIndex = 2;
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(12, 200);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(13, 20);
            this.LabelCount.TabIndex = 3;
            this.LabelCount.Text = " ";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Location = new System.Drawing.Point(112, 9);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(232, 20);
            this.LabelDescription.TabIndex = 4;
            this.LabelDescription.Text = "Введите проверяемые слова";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 321);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.LabelOut);
            this.Controls.Add(this.StartButton);
            this.Name = "Form";
            this.Text = "Палиндромы";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LabelOut;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label LabelDescription;
    }
}


