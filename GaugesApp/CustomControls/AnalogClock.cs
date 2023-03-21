using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows.Data;

namespace GaugesApp.CustomControls
{
    [TemplatePart(Name = "PART_HourHand", Type = typeof(Line))]
    [TemplatePart(Name = "PART_MinutedHand", Type = typeof(Line))]
    [TemplatePart(Name = "PART_SecondHand", Type = typeof(Line))]

    public class AnalogClock : Clock
    {
        private Line hourHand;
        private Line minuteHand;
        private Line secondHand;

        static AnalogClock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnalogClock), new FrameworkPropertyMetadata(typeof(AnalogClock)));
        }

        public override void OnApplyTemplate()
        {
            hourHand = (Line)Template.FindName("Part_HourHand", this);
            minuteHand = (Line)Template.FindName("Part_MinuteHand", this);
            secondHand = (Line)Template.FindName("Part_SecondHand", this);
            
            base.OnApplyTemplate();
        }

        protected override void OnTimeChanged(DateTime time)
        {
            UpdateHandAngles(time);
            base.OnTimeChanged(time);
        }

        private void UpdateHandAngles(DateTime time)
        {
            double secondHaandAngle = time.Second * 6.0;
            double minuteHandAngle = (time.Minute * 6.0) + (time.Second * 6.0 / 60.0);
            double hourHandAngle = (time.Hour * 30.0) + (time.Minute * 30.0 / 60.0);

            secondHand.RenderTransform = new RotateTransform(secondHaandAngle, .5, .5);
            minuteHand.RenderTransform = new RotateTransform(minuteHandAngle, .5, .5);
            hourHand.RenderTransform = new RotateTransform(hourHandAngle, .5, .5);
        }
    }
}
