using Banrk_Lab.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banrk_Lab
{
    public partial class Form1 : Form
    {
        readonly TextBoxBase[] textBoxes;
        List<Worker> workers;

        public Form1()
        {
            InitializeComponent();
            workerTypePicker.SelectedIndex = 0;

            textBoxes = new TextBoxBase[4] { NameTextBox, SalaryTextBox, BirthdayTextBox, HireDateTextBox };
            workers = new List<Worker>();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> workerKwargs = new Dictionary<string, string>(textBoxes.Length);
            string workerType = workerTypePicker.SelectedItem.ToString();

            foreach (var textBox in textBoxes)
            {
                if (!isStringEmpty(textBox.Text))
                {
                    workerKwargs.Add(textBox.Tag.ToString(), textBox.Text);
                }
            }

            Worker newWorker = null;
            try
            {
                newWorker = WorkersBuilder.MakeWorker(workerType, workerKwargs);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (newWorker != null)
            {
                addNewWorker(newWorker);
            }
        }

        private void addNewWorker(Worker worker)
        {
            if (workers.Find((Worker x) => x.Equals(worker)) == null)
            {
                workers.Add(worker);
                workersListBox.Items.Add(
                    String.Format(
                        "Type: {0} | {1}",
                        new object[] { worker.GetType().Name, worker.ToString() }
                    )
                );
            }
            else
            {
                MessageBox.Show(
                    "This worker already exists!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

        }

        private static bool isStringEmpty(string x)
        {
            return x.Replace(" ", "").Replace(".", "") == "";
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == 8);
        }
    }
}
