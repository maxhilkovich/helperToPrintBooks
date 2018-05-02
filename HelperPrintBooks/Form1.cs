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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelIncorrect.Text = "";
            labelAttention1.Text = "";
            labelAttention2.Text = "";
            labelWhatLine.Text = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            // инициализация
            try
            {
                labelIncorrect.Text = "";
                labelAttention1.Text = "";
                labelAttention2.Text = "";
                labelWhatLine.Text = "";
                textPagePrintAll.Text = "";
                listBoxSide1.Items.Clear();
                listBoxSide2.Items.Clear();
                int pageStart = Convert.ToInt32(firstPage.Text);
                int pageEnd = Convert.ToInt32(secondPage.Text);
                if (pageStart > pageEnd)
                    throw new Exception();
                int remainder = (pageEnd - pageStart + 1) % 4;

                if (remainder > 0)
                {
                    labelAttention1.Text = "Внимание! Добавлены номера страниц: ";
                    switch (remainder)
                    {
                        case 3: labelAttention1.Text = labelAttention1.Text + (pageEnd + 1); break;
                        case 2: labelAttention1.Text = labelAttention1.Text + (pageEnd + 1) + ", " + (pageEnd + 2); break;
                        case 1: labelAttention1.Text = labelAttention1.Text + (pageEnd + 1) + ", " + (pageEnd + 2) + ", " + (pageEnd + 3); break;
                        default: labelAttention1.Text = "Какая-то ошибка...";
                            break;
                    }
                    DataStorage.NumberPage = labelAttention1.Text;
                    labelAttention2.Text = "Их необходимо изменить на чистые существующие";
                    FormNewPages formNewPages = new FormNewPages();
                    formNewPages.ShowDialog();
                }

                int sheet = (pageEnd - pageStart + 1) / 4;
                int pageEndUp;
                if (remainder == 0)
                    pageEndUp = pageEnd;
                else pageEndUp = pageEnd + (4 - remainder);
                // расчет
                int[] page1 = new int[(pageEndUp - pageStart + 1) / 2]; // массив страниц для нечетной стороны
                int[] page2 = new int[page1.Length];  // для четной стороны
                int w = 0, start = pageStart, end = pageEndUp;
                while (w < page1.Length)
                {
                    page1[w] = end;
                    page1[w + 1] = start;
                    --end;
                    ++start;
                    page2[w] = start;
                    page2[w + 1] = end;
                    --end;
                    ++start;
                    w = w + 2;
                }

                // пересчет исходя из количества листов
                if (textHowMatchPage.Text == "")
                    textHowMatchPage.Text = "0";
                int sheetHowMatch = Convert.ToInt32(textHowMatchPage.Text);
                if (sheetHowMatch == 0)
                {
                    listBoxSide1.Items.Add(ShowPage(page1, false));
                    listBoxSide2.Items.Add(ShowPage(page2, true));
                }
                else
                {
                    int p = 0;
                    int i = 0;
                    int[] pereborSheet1 = new int[sheetHowMatch * 2];
                    int[] pereborSheet2 = new int[sheetHowMatch * 2];
                    while (p < page1.Length)
                    {
                        if (i < sheetHowMatch * 2)
                        {
                            pereborSheet1[i] = page1[p];
                            pereborSheet2[i] = page2[p];
                            ++i;
                        }
                        else
                        {
                            i = 0;
                            listBoxSide1.Items.Add(ShowPage(pereborSheet1, false));
                            listBoxSide2.Items.Add(ShowPage(pereborSheet2, true));
                            pereborSheet1 = new int[sheetHowMatch * 2];
                            pereborSheet2 = new int[sheetHowMatch * 2];
                            --p;
                        }
                        ++p;
                        if (p == page1.Length)
                        {
                            int[] temp = new int[i];
                            for (int j = 0; j < temp.Length; j++)
                            {
                                temp[j] = pereborSheet1[j];
                            }
                            pereborSheet1 = temp;
                            temp = new int[i];
                            for (int j = 0; j < temp.Length; j++)
                            {
                                temp[j] = pereborSheet2[j];
                            }
                            pereborSheet2 = temp;
                            listBoxSide1.Items.Add(ShowPage(pereborSheet1, false));
                            listBoxSide2.Items.Add(ShowPage(pereborSheet2, true));
                        }
                    }
                }
            }
            catch (Exception)
            {
                labelAttention1.Text = "";
                labelAttention2.Text = "";
                labelIncorrect.Text = "   Вы ввели неккоректные данные!!!";
                listBoxSide1.Items.Clear();
                listBoxSide2.Items.Clear();
                firstPage.Text = "";
                secondPage.Text = "";
                textHowMatchPage.Text = "";
                textPagePrintAll.Text = "";
            }
        }

        private string ShowPage(int[] pageArray, bool parity)
        {
            bool flag = true;
            string pageBox = "";
            int[] change = new int[pageArray.Length];
            if (radiobuttonHowDo.Checked && parity)
            {
                for (int i = 0; i < pageArray.Length; i = i + 2)
                {
                    change[pageArray.Length - i - 1] = pageArray[i + 1];
                    change[pageArray.Length - i - 2] = pageArray[i];
                }
                pageArray = change;
            }

            foreach (var item in pageArray)
            {
                if (flag)
                {
                    pageBox = Convert.ToString(item);
                    flag = false;
                }
                else pageBox = pageBox + "," + item;
            }
            return pageBox;
        }

        private void listBoxSide1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textPagePrintAll.Text = listBoxSide1.Text;
            labelWhatLine.Text = "Вставлена " + Convert.ToString(listBoxSide1.SelectedIndex + 1) + " строка передней стороны";
        }

        private void listBoxSide2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textPagePrintAll.Text = listBoxSide2.Text;
            labelWhatLine.Text = "Вставлена " + Convert.ToString(listBoxSide2.SelectedIndex + 1) + " строка оборотной стороны";
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            about abouT = new about();
            abouT.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHowDo_Click(object sender, EventArgs e)
        {
            HowThisDo howThisDo = new HowThisDo();
            howThisDo.Width = 650;
            howThisDo.ShowDialog();
        }

        private void buttonCopyBuffer_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textPagePrintAll.Text);
        }

        private void labelAttention1_Click(object sender, EventArgs e)
        {

        }

    }

    public static class DataStorage
    {
        public static string NumberPage { set; get; }
    }
}
