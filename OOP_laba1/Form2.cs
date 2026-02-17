using System;
using System.Windows.Forms;

namespace OOP_laba1
{
    public partial class Form2 : Form
    {
        private static bool isShowedInfo = false;

        private Airport _instance;

        public Form2()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isShowedInfo)
            {
                label_Info.Text = _instance.ToString();
                button_show.Text = "Скрыть информацию";
            }
            else
            {
                label_Info.Text = "";
                button_show.Text = "Показать информацию";
            }

            isShowedInfo = !isShowedInfo;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in panel_Input.Controls)
            {
                if (c != comboBox && c != saveButton)
                    c.Visible = false;
            }

            switch (comboBox.SelectedIndex)
            {
                case 0: textBox_Name.Visible = true; break;
                case 1: textBox_Location.Visible = true; break;
                case 2: numericUpDown_FlightsPerDay.Visible = true; break;
                case 3: numericUpDown_TicketsSold.Visible = true; break;
                case 4: numericUpDown_Balance.Visible = true; break;
                case 5: numericUpDown_Rating.Visible = true; break;
                case 6: numericUpDown_Employee.Visible = true; break;
            }
        }

        private void ParseValues()
        {
            try
            {
                switch (comboBox.SelectedIndex)
                {
                    case 0:

                }
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}
