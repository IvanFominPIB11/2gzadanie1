using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _2gzadanie1
{
    class OddEvenDemo
    {
        static void Main()
        {
            int number, delenie;
            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число чтобы поделить на 3:")
                );
            
            delenie = number/3;
            string txt = "Ответ "+delenie+" !";
            MessageBox.Show(txt);


        }
    }
}
