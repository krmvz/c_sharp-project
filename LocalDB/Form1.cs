using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.modelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "modelDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.modelDataSet.Customers);

        }

        private void genderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = "Male";
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
                genderCheckBox.Text = "Famale";
            else
                genderCheckBox.Text = "??";
        }
    }
}
