using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LogistikFleet.Renders
{
    class CustomTimePicker: TimePicker
    {
        public event EventHandler TimeChanged;
        private TimeSpan StartValue { get; set; }
        public CustomTimePicker()
        {
            this.Focused += OnFoused;
            this.Unfocused += OnUnfocused;
        }
        private void OnFoused(object sender, FocusEventArgs e)
        {
            StartValue = this.Time;
        }
        private void OnUnfocused(object sender, FocusEventArgs e)
        {
            if (StartValue != this.Time)
            {
                TimeChanged?.Invoke(this, e);
            }
        }
    }
}
