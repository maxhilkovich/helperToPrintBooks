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
    public partial class FormNewPages : Form
    {
        public FormNewPages()
        {
            InitializeComponent();
            labelIncorrect.Text = DataStorage.NumberPage;
            label2.Text = "Их необходимо изменить на чистые существующие";

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
