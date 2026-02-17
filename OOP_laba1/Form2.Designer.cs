namespace OOP_laba1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Bottom;
        private System.Windows.Forms.Panel panel_Input;

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Location;

        private System.Windows.Forms.NumericUpDown numericUpDown_Balance;
        private System.Windows.Forms.NumericUpDown numericUpDown_FlightsPerDay;
        private System.Windows.Forms.NumericUpDown numericUpDown_TicketsSold;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rating;
        private System.Windows.Forms.NumericUpDown numericUpDown_Employee;

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_show;

        private System.Windows.Forms.Label label_Info;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            this.panel_Input = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Location = new System.Windows.Forms.TextBox();
            this.numericUpDown_Balance = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FlightsPerDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TicketsSold = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Rating = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Employee = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Bottom = new System.Windows.Forms.TableLayoutPanel();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.panel_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FlightsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TicketsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Employee)).BeginInit();
            this.tableLayoutPanel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Controls.Add(this.label_Info, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.button_show, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Input, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Bottom, 0, 3);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 4;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(684, 411);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // label_Info
            // 
            this.label_Info.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Info.Location = new System.Drawing.Point(3, 0);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(678, 251);
            this.label_Info.TabIndex = 0;
            // 
            // button_show
            // 
            this.button_show.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_show.Location = new System.Drawing.Point(304, 259);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 1;
            this.button_show.Text = "Показать информацию";
            this.button_show.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Input
            // 
            this.panel_Input.Controls.Add(this.comboBox);
            this.panel_Input.Controls.Add(this.textBox_Name);
            this.panel_Input.Controls.Add(this.textBox_Location);
            this.panel_Input.Controls.Add(this.numericUpDown_Balance);
            this.panel_Input.Controls.Add(this.numericUpDown_FlightsPerDay);
            this.panel_Input.Controls.Add(this.numericUpDown_TicketsSold);
            this.panel_Input.Controls.Add(this.numericUpDown_Rating);
            this.panel_Input.Controls.Add(this.numericUpDown_Employee);
            this.panel_Input.Controls.Add(this.saveButton);
            this.panel_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Input.Location = new System.Drawing.Point(3, 294);
            this.panel_Input.Name = "panel_Input";
            this.panel_Input.Size = new System.Drawing.Size(678, 54);
            this.panel_Input.TabIndex = 2;
            // 
            // comboBox
            // 
            this.comboBox.Items.AddRange(new object[] { "Название", "Местоположение", "Полетов за день", "Продано билетов за день", "Баланс", "Рейтинг аэропорта", "Количество работников" });
            this.comboBox.Location = new System.Drawing.Point(10, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(180, 20);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_Location
            // 
            this.textBox_Location.Location = new System.Drawing.Point(180, 20);
            this.textBox_Location.Name = "textBox_Location";
            this.textBox_Location.Size = new System.Drawing.Size(200, 20);
            this.textBox_Location.TabIndex = 2;
            // 
            // numericUpDown_Balance
            // 
            this.numericUpDown_Balance.DecimalPlaces = 2;
            this.numericUpDown_Balance.Location = new System.Drawing.Point(180, 20);
            this.numericUpDown_Balance.Maximum = new decimal(new int[] { 1569325056, 23283064, 0, 0 });
            this.numericUpDown_Balance.Name = "numericUpDown_Balance";
            this.numericUpDown_Balance.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_Balance.TabIndex = 3;
            this.numericUpDown_Balance.ThousandsSeparator = true;
            // 
            // numericUpDown_FlightsPerDay
            // 
            this.numericUpDown_FlightsPerDay.Location = new System.Drawing.Point(180, 20);
            this.numericUpDown_FlightsPerDay.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            this.numericUpDown_FlightsPerDay.Name = "numericUpDown_FlightsPerDay";
            this.numericUpDown_FlightsPerDay.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_FlightsPerDay.TabIndex = 4;
            // 
            // numericUpDown_TicketsSold
            // 
            this.numericUpDown_TicketsSold.Location = new System.Drawing.Point(180, 20);
            this.numericUpDown_TicketsSold.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            this.numericUpDown_TicketsSold.Name = "numericUpDown_TicketsSold";
            this.numericUpDown_TicketsSold.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_TicketsSold.TabIndex = 5;
            // 
            // numericUpDown_Rating
            // 
            this.numericUpDown_Rating.DecimalPlaces = 2;
            this.numericUpDown_Rating.Location = new System.Drawing.Point(180, 20);
            this.numericUpDown_Rating.Maximum = new decimal(new int[] { -1530494976, 232830, 0, 0 });
            this.numericUpDown_Rating.Name = "numericUpDown_Rating";
            this.numericUpDown_Rating.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_Rating.TabIndex = 6;
            this.numericUpDown_Rating.ThousandsSeparator = true;
            // 
            // numericUpDown_Employee
            // 
            this.numericUpDown_Employee.Location = new System.Drawing.Point(180, 20);
            this.numericUpDown_Employee.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            this.numericUpDown_Employee.Name = "numericUpDown_Employee";
            this.numericUpDown_Employee.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown_Employee.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(400, 18);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel_Bottom
            // 
            this.tableLayoutPanel_Bottom.ColumnCount = 2;
            this.tableLayoutPanel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Bottom.Controls.Add(this.button_Back, 0, 0);
            this.tableLayoutPanel_Bottom.Controls.Add(this.button_Exit, 1, 0);
            this.tableLayoutPanel_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Bottom.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel_Bottom.Name = "tableLayoutPanel_Bottom";
            this.tableLayoutPanel_Bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Bottom.Size = new System.Drawing.Size(678, 54);
            this.tableLayoutPanel_Bottom.TabIndex = 3;
            // 
            // button_Back
            // 
            this.button_Back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Back.Location = new System.Drawing.Point(3, 15);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 23);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "<<Назад";
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Exit.Location = new System.Drawing.Point(600, 15);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Выход";
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOP laba 1";
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.panel_Input.ResumeLayout(false);
            this.panel_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FlightsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TicketsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Employee)).EndInit();
            this.tableLayoutPanel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
