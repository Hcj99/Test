using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LogicTest
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String[] firstCard = Regex.Split(tBOne.Text, ",");
            String[] secondCard = Regex.Split(tBTwo.Text, ",");
            String[] thirdCard = Regex.Split(tBThree.Text, ",");

            String sFirst = firstCard[0];
            String fFirst = firstCard[1];
            String cFirst = firstCard[2];
            String nFirst = firstCard[3];


            String sSecond = secondCard[0];
            String fSecond = secondCard[1];
            String cSecond = secondCard[2];
            String nSecond = secondCard[3];

            String sThird= thirdCard[0];
            String fThird = thirdCard[1];
            String cThird = thirdCard[2];
            String nThird = thirdCard[3];

            if((StringAllSame(sFirst,sSecond,sThird)|| StringAllDifferent(sFirst, sSecond, sThird))&& (StringAllSame(fFirst, fSecond, fThird) || StringAllDifferent(fFirst, fSecond, fThird))&&(StringAllSame(cFirst, cSecond, cThird) || StringAllDifferent(cFirst, cSecond, cThird))&&(StringAllSame(nFirst, nSecond, nThird) || StringAllDifferent(nFirst, nSecond, nThird)))
            {
                MessageBox.Show("It is a Set!");
            }

            else
            {
                MessageBox.Show("It is NOT a Set!");
            }
        }


        public Boolean StringAllSame (String first, String second, String third)
        {
            if (first.Equals(second)&&second.Equals(third))
            {
                MessageBox.Show("All Same!");
                return true;
                
            }

            return false;
        }


        public Boolean StringAllDifferent(String first, String second, String third)
        {
            if ((first.Equals(second)==false) && (second.Equals(third)==false) && (third.Equals(first)==false))
            {
                MessageBox.Show("All Different!");
                return true;
                
            }

            return false;
        }

        
    }
}
