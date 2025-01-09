using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF5
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int a = 5;
            CalculateOut(a, out int b, out int c);
            aOut.Text = "a=" + a.ToString();
            bOut.Text = "b=" + b.ToString();
            cOut.Text = "c=" + c.ToString();


            CalculateRef(a, ref b, ref c);
            aRef.Text = "a=" + a.ToString();
            bRef.Text = "b=" + b.ToString();
            cRef.Text = "c=" + c.ToString();


            string s = "Message: test msg.";
            sExt.Text = s;
            sIsMessage.Text = s.IsMessage().ToString();


            int? i = null;
            iNullable.Text = "i=" + i.ToString();

            iNotNullable.Text = i.HasValue.ToString();
        }








        public int CalculateOut(int a, out int b, out int c)
        {
            b = c = a;

            b /= 2;
            c *= 2;
            return  b + c;
        }

        public int CalculateRef(int a, ref int b, ref int c)
        {
            b /= 3;
            c *= 3;
            return  b + c;
        }

        public int? nullableInt(int i)
        {
            int? value = i;
            return value;
        }
    }


    public static class ExtendingMethods
    {
        public static bool IsMessage(this string s)
        {
            if (s.ToLower().Contains("message")) return true;
            return false;
        }
    }
}
