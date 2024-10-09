using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color color;
        byte a = 43;
        byte r = 174;
        byte g = 234;
        byte b = 255;
        SolidColorBrush pinzell = new SolidColorBrush();


        public MainWindow()
        {
            InitializeComponent();
            color = Color.FromArgb(a, r, g, b);
            pinzell.Color = color;
            stkPanell.Background = pinzell;
            cpPicker.SelectedColor = color;

        }

        private void aColorValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            a = (byte)aColorValue.Value;
            color = Color.FromArgb(a, r, g, b);
            pinzell.Color = color;
            if (cpPicker != null)
                cpPicker.SelectedColor = color;
        }

        private void rColorValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            r = (byte)rColorValue.Value;
            color = Color.FromArgb(a, r, g, b);
            pinzell.Color = color;
            if (cpPicker != null)
                cpPicker.SelectedColor = pinzell.Color;
        }

        private void gColorValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            g = (byte)gColorValue.Value;
            color = Color.FromArgb(a, r, g, b);
            pinzell.Color = color;
            if (cpPicker != null)
                cpPicker.SelectedColor = pinzell.Color;
        }

        private void bColorValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            b = (byte)bColorValue.Value;
            color = Color.FromArgb(a, r, g, b);
            pinzell.Color = color;
            if (cpPicker != null)
                cpPicker.SelectedColor = pinzell.Color;
        }

        private void cpPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            color = (Color)cpPicker.SelectedColor;
            pinzell.Color = color;
            aColorValue.Value = color.A;
            rColorValue.Value = color.R;
            gColorValue.Value = color.G;
            bColorValue.Value = color.B;
            
        }
    }
}