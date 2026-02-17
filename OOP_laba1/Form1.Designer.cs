namespace OOP_laba1
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
            this.labInfoLabel = new System.Windows.Forms.Label();
            this.labInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labInfoLabel
            // 
            this.labInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInfoLabel.Location = new System.Drawing.Point(137, 9);
            this.labInfoLabel.Name = "labInfoLabel";
            this.labInfoLabel.Size = new System.Drawing.Size(416, 302);
            this.labInfoLabel.TabIndex = 0;
            this.labInfoLabel.Text = "Лабораторная работа №1. Выполнили студенты группы 24ВП1 Песков Роман и Шадчина Ел" +
    "ена";
            // 
            // labInfoButton
            // 
            this.labInfoButton.Location = new System.Drawing.Point(274, 325);
            this.labInfoButton.Name = "labInfoButton";
            this.labInfoButton.Size = new System.Drawing.Size(127, 37);
            this.labInfoButton.TabIndex = 1;
            this.labInfoButton.Text = "Продолжить";
            this.labInfoButton.UseVisualStyleBackColor = true;
            this.labInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 406);
            this.Controls.Add(this.labInfoButton);
            this.Controls.Add(this.labInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP laba 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labInfoLabel;
        private System.Windows.Forms.Button labInfoButton;
    }
}

