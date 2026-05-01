using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace WeatherMonitor
{
    public partial class WeatherForm : Form, IView
    {
        public WeatherForm()
        {
            InitializeComponent();

            buttonSearch.Click += ButtonSearch_Click;
            comboBoxCapitals.SelectedIndexChanged += ComboBoxCapitals_SelectedIndexChanged;
            textBoxCity.KeyDown += TextBoxCity_KeyDown;
        }

        private void TextBoxCity_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SearchByCityClicked?.Invoke();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CityInput
        {
            get { return textBoxCity.Text; }
            set { textBoxCity.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedCapital
        {
            get { return comboBoxCapitals.SelectedItem?.ToString() ?? string.Empty; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TemperatureDisplay
        {
            get { return labelTemp.Text; }
            set { labelTemp.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PressureDisplay
        {
            get { return labelPressure.Text; }
            set { labelPressure.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string HumidityDisplay
        {
            get { return labelHumidity.Text; }
            set { labelHumidity.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string WindDisplay
        {
            get { return labelWind.Text; }
            set { labelWind.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string WeatherIconUrl
        {
            get { return pictureBoxIcon.ImageLocation ?? string.Empty; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    pictureBoxIcon.Image = null;
                }
                else
                {
                    pictureBoxIcon.LoadAsync(value);
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> EuropeanCapitals
        {
            set { comboBoxCapitals.DataSource = value; }
        }

        public event Action? SearchByCityClicked;
        public event Action? CapitalSelectionChanged;

        private void ButtonSearch_Click(object? sender, EventArgs e)
        {
            SearchByCityClicked?.Invoke();
        }

        private void ComboBoxCapitals_SelectedIndexChanged(object? sender, EventArgs e)
        {
            CapitalSelectionChanged?.Invoke();
        }

    }
}
