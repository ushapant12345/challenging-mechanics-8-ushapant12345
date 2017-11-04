using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace challenging_mechanics_8_ushapant12345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            int[,] someIntegers = new int[5, 5];

            someIntegers[2, 1] = 3;
            someIntegers[2, 2] = 85;
            someIntegers[1, 4] = 789;
            someIntegers[4, 0] = 12;
            someIntegers[3, 2] = 16;
            for (int row = 0; row < someIntegers.GetLength(0); row++)
            {

                for (int col = 0; col < someIntegers.GetLength(1); col++)
                {
                    Console.WriteLine(someIntegers[row, col].ToString());
                }
            }


            double[,] someDoubles = new double[5, 5];
            someDoubles[3, 2] = 7.8632;
            someDoubles[2, 0] = 3.7;
            someDoubles[0, 4] = 65.4;
            someDoubles[0, 2] = 63.1;
            someDoubles[3, 3] = 12.5;
            for (int row = 0; row < someDoubles.GetLength(0); row++)
            {

                for (int col = 0; col < someDoubles.GetLength(1); col++)
                {
                    Console.WriteLine(someDoubles[row, col].ToString());
                }
            }


            string[,] someStrings = new string[6, 3];

            someStrings[1, 2] = "Fist";
            someStrings[1, 1] = "Magic";
            someStrings[5, 2] = "Pear";
            someStrings[0, 0] = "Red";
            someStrings[2, 1] = "Dog";
            someStrings[3, 0] = "Cat";
            someStrings[3, 2] = "Apple";
            someStrings[4, 1] = "Wagon";
            for (int row = 0; row < someStrings.GetLength(0); row++)
            {

                for (int col = 0; col < someStrings.GetLength(1); col++)
                {
                    Console.WriteLine(someStrings[row, col]);
                }
            }


            char[,] someChars = new char[5, 5];
         

            someChars[2, 3] = 'N';
            someChars[1, 4] = 'J';
            someChars[2, 2] = 'R';
            someChars[3, 4] = 'T';
            someChars[4, 2] = 'X';
            someChars[0, 1] = 'B';
            someChars[1, 0] = 'F';
           

            for (int row = 0; row < someChars.GetLength(0); row++)
            {

                for (int col = 0; col < someChars.GetLength(1); col++)
                {
                    MessageBox.Show(someChars[row, col].ToString());
                  
                }
               
            }
           










            int[,] integerSetPrint = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] doubleSetPrint = { { 10.1, 10.2 }, { 10.3, 10.4 }, { 10.5, 10.6 } };

            float[,] floatSetPrint = { { 11.6f, 21.5f, 31.4f }, { 41.3f, 51.2f, 61.1f } };





            string strFor26 = "";
            for (int ndx1 = 0; ndx1 < integerSetPrint.GetLength(0); ndx1++)
            {
                for (int ndx2 = 0; ndx2 < integerSetPrint.GetLength(1); ndx2++)
                {
                    strFor26 += integerSetPrint[ndx1, ndx2] + "-";
                }
                strFor26 += "\r\n";
            }
            MessageBox.Show(strFor26);




            string strFor27 = "";
            for (int ndx1 = integerSetPrint.GetLength(0)-1; ndx1 >=0; ndx1--)
            {
                for (int ndx2=integerSetPrint.GetLength(1)-1; ndx2 >= 0; ndx2--)
                {
                    strFor27 += integerSetPrint[ndx1, ndx2] + "*";
                }
                strFor27 += "\r\n";
            }
            MessageBox.Show(strFor27);




            string strFor28 = "";

            for (int ndx1 = 0; ndx1 < integerSetPrint.GetLength(0); ndx1++)
               
            {
                 integerSetPrint[2, 1] = 7;
                for (int ndx2 = 0; ndx2 < integerSetPrint.GetLength(1); ndx2++)
                {
                    strFor28 += integerSetPrint[ ndx2,ndx1] + "^";
                }
                strFor28 += "\r\n";
            }
            MessageBox.Show(strFor28);




            string strFor29 = "";

            for (int ndx1 = 0; ndx1 < doubleSetPrint.GetLength(0); ndx1++)

            {
                
                for (int ndx2 = 0; ndx2 < doubleSetPrint.GetLength(1); ndx2++)
                {
                    strFor29 += doubleSetPrint[ ndx1,ndx2] + "|";
                }
                strFor29 += "\r\n";
            }
            MessageBox.Show(strFor29);



            string strFor30 = "";

            for (int ndx1 = 0; ndx1 < doubleSetPrint.GetLength(1); ndx1++)

            {

                for (int ndx2 = 0; ndx2 < doubleSetPrint.GetLength(0); ndx2++)
                {
                    strFor30 += doubleSetPrint[ ndx2, ndx1] + "@";
                }
                strFor30 += "\r\n";
            }
            MessageBox.Show(strFor30);




            string strFor31 = "";

            for (int ndx1 = 0; ndx1 < floatSetPrint.GetLength(0); ndx1++)

            {

                for (int ndx2 = 0; ndx2 < floatSetPrint.GetLength(1); ndx2++)
                {
                    strFor31 += floatSetPrint[ndx1,ndx2] + "<";
                }
                strFor31 += "\r\n";
            }
            MessageBox.Show(strFor31);




            string strFor32 = "";

            for (int ndx1 = 0; ndx1 < floatSetPrint.GetLength(1); ndx1++)

            {

                for (int ndx2 = 0; ndx2 < floatSetPrint.GetLength(0); ndx2++)
                {
                    strFor32 += floatSetPrint[ndx2,ndx1] + "$";
                }
                strFor32 += "\r\n";
            }
            MessageBox.Show(strFor32);




        }
    }
    
}
