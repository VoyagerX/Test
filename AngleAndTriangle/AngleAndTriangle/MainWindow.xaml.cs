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

namespace AngleAndTriangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Angle
        {
            // Field 
            private int degree;

            // Constructor that takes 
            public Angle()
            {

            }

            public int deg
            {
                get { return degree; }
                set { degree = value; }
            }

            

            // Method 
            public int Sum(Angle angle2)
            {
                int sum;

                sum = this.deg + angle2.deg;

                if (sum>360)
                {
                    sum = sum - 360;
                }

                return sum;
            }

            public int Sub(Angle angle2)
            {
                int sub;

                sub = this.deg - angle2.deg;

                if (sub < 0)
                {
                    sub = sub + 360;
                }

                return sub;
            }

            public double Radian()
            {
                double rad;

                rad = (degree*Math.PI)/180;

                return rad;
            }
        }

        public class Triangle:Angle

        {
            // Field 
            public double katetA;
            public double katetB;


            // Constructor that takes 
            public Triangle(double ak, double bk)
            {
                katetA = ak;
                katetB = bk;
            }

            public double Area()
            {
                double area;

                area = (katetA*katetB) / 2;

                return area;
            }


        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aangle, bangle;

            Csumbox.Text = "";

            aangle = Convert.ToInt32(Asumbox.Text);
            bangle = Convert.ToInt32(Bsumbox.Text);


            if (aangle < 0 || aangle > 360 || bangle < 0 || bangle > 360)
            {
                MessageBox.Show("Углы должны быть в диапазоне от 0 до 360 градусов");
                return;
            }

            Angle A = new Angle();
            Angle B = new Angle();

            A.deg = aangle;
            B.deg = bangle;

            double res;

            res = A.Sum(B);

            Csumbox.Text = res.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            int aangle, bangle;

            Csubbox.Text = "";

            aangle = Convert.ToInt32(Asubbox.Text);
            bangle = Convert.ToInt32(Bsubbox.Text);


            if (aangle < 0 || aangle > 360 || bangle < 0 || bangle > 360)
            {
                MessageBox.Show("Углы должны быть в диапазоне от 0 до 360 градусов");
                return;
            }

            Angle A = new Angle();
            Angle B = new Angle();

            A.deg = aangle;
            B.deg = bangle;

            double res;

            res = A.Sub(B);

            Csubbox.Text = res.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            int aangle;

            Cradbox.Text = "";

            aangle = Convert.ToInt32(Aradbox.Text);
            
            

            if (aangle < 0 || aangle > 360)
            {
                MessageBox.Show("Углы должны быть в диапазоне от 0 до 360 градусов");
                return;
            }

            Angle A = new Angle();
            

            A.deg = aangle;
            

            double res;

            res = A.Radian();

            Cradbox.Text = res.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double aka, bka;

            Ctribox.Text = "";

            aka = Convert.ToDouble(Atribox.Text);
            bka = Convert.ToDouble(Btribox.Text);


            if (aka <= 0 ||  bka <= 0 )
            {
                MessageBox.Show("Катеты должны быть неотрицательными");
                return;
            }

            Triangle A = new Triangle(aka,bka);

            double res;

            res = A.Area();

            Ctribox.Text = res.ToString();
        }


    }
}
