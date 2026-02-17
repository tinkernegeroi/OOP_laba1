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
            numericUpDown_Balance.Minimum = -1000;
            numericUpDown_Employee.Minimum = -1000;
            _instance = new Airport();
            _instance = new Airport();
            _instance = new Airport();
            _instance = new Airport(
                "Домодедово",
                "Московская область",
                150,
                2000,
                503232106,
                4.92,
                3124
            );
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
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrWhiteSpace(textBox_Name.Text))
                        throw new AirportInvalidCastException("Название не может быть пустым.");

                    _instance.Name = textBox_Name.Text;
                    break;
                case 1:
                    if (string.IsNullOrWhiteSpace(textBox_Location.Text))
                        throw new AirportInvalidCastException("Местоположение не может быть пустым.");

                    _instance.Location = textBox_Name.Text;
                    break;
                case 2:
                    _instance.FlightsPerDay =
                        (int)numericUpDown_FlightsPerDay.Value < 0
                            ? throw new AirportInvalidCastException("Значение не может быть отрицательным")
                            : (int)numericUpDown_FlightsPerDay.Value;
                    break;
                case 3:
                    _instance.TicketsSold = (int)numericUpDown_TicketsSold.Value < 0
                        ? throw new AirportInvalidCastException("Значение не может быть отрицательным")
                        : (int)numericUpDown_TicketsSold.Value;
                    break;
                case 4:
                    _instance.Balance = numericUpDown_Balance.Value;
                    break;
                case 5:
                    _instance.Rating = (int)numericUpDown_Rating.Value < 0
                        ? throw new AirportInvalidCastException("Значение не может быть отрицательным")
                        : (int)numericUpDown_Rating.Value;
                    break;
                case 6:
                    _instance.EmployeesCount = (int)numericUpDown_Employee.Value < 0
                        ? throw new AirportInvalidCastException("Значение не может быть отрицательным")
                        : (int)numericUpDown_Employee.Value;
                    break;
            }
            label_Info.Text = _instance.ToString();
            if (!isShowedInfo)
            {
                button_show.Text = "Скрыть информацию";
                isShowedInfo = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ParseValues();
            }
            catch (Exception exception)
            {
                NativeMessageBox.MessageBox(
                    IntPtr.Zero,
                    exception.Message,
                    "Ошибка",
                    NativeMessageBox.MB_OK | NativeMessageBox.MB_ICONERROR
                );
            }
        }
    }
}
