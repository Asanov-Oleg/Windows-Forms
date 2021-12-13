using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataSourcesWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rBProductDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rBProductDataSet.Товары' table. You can move, or remove it, as needed.
            this.товарыTableAdapter.Fill(this.rBProductDataSet.Товары);
            // TODO: This line of code loads data into the 'rBProductDataSet.Поставщики' table. You can move, or remove it, as needed.
            this.поставщикиTableAdapter.Fill(this.rBProductDataSet.Поставщики);

        }
    }
}
