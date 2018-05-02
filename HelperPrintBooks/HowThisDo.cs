using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelperPrintBooks
{
    public partial class HowThisDo : Form
    {
        public HowThisDo()
        {
            InitializeComponent();
            labelIncorrect.Text =   "   При распечатке информации в виде книги с большим количеством страниц могут возникнуть проблемы:\r\n"
            + "- закончится тонер(чернила) в принтере;\r\n"
            + "- зажевывается бумага;\r\n"
            + "- опция печати \"книжкой\" присутствует не во всех драйверах принтера.";
            label2.Text = "   Вначале необходимо ввести первую и последнюю страницы  печатуемого документа. "
                            + "Программа просчитает и при необходимости добавит несколько страниц для парности. "
                          + "Затем  необходимо  внести  по сколько страниц  будете печатать,  т.е количество листов в переплете "
                          + "Также имеет значение какой стороной принтер выдает страницы. "
                          + "   По нажатии \"Считать\" программа  выдает результаты в окнах  \"Передняя сторона\" и "
                          + "\"Оборотная сторона\".  Строки в этих окнах  и являются переплетами.  Т.е. 1 строка "
                          + "окон передней и  оборотной стороны и есть 1 переплет.";
        }
       
        private void buttonResult_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelIncorrect_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
