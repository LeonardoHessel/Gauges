using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GaugesApp.CustomControls
{
    [TemplatePart(Name = "PART_Colon", Type = typeof(UIElement))]

    public class DigitalClock : Clock
    {
        private UIElement colon;

        public static readonly DependencyProperty ColonBlinkProperty =
            DependencyProperty.Register("ColonBlink", typeof(bool), typeof(DigitalClock), new PropertyMetadata(true));

        public DigitalClock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DigitalClock), new FrameworkPropertyMetadata(typeof(DigitalClock)));
        }

        public bool ColonBlink
        {
            get { return (bool)GetValue(ColonBlinkProperty); }
            set { SetValue(ColonBlinkProperty, value); }
        }

        public override void OnApplyTemplate()
        {
            colon = (UIElement)Template.FindName("PART_Colon", this);

            base.OnApplyTemplate();
        }

        protected override void OnTimeChanged(DateTime newTime)
        {
            if (colon != null)
            {
                if (ColonBlink && !ShowSeconds)
                {
                    colon.Visibility = colon.IsVisible ? Visibility.Visible : Visibility.Hidden;
                }
                else
                {
                    colon.Visibility = Visibility.Visible;
                }
            }
            base.OnTimeChanged(newTime);
        }
    }
}
