using System;
using System.Threading;
using System.Windows.Forms;
using DsaaApp1.Codes;
using DsaaApp1.Codes._1.Sort;

namespace DsaaApp1
{
    public partial class Form1 : Form, IUiUpdater
    {
        private readonly SynchronizationContext _synchronizationContext;

        public Form1()
        {
            InitializeComponent();

            _synchronizationContext = SynchronizationContext.Current;
        }

        public void UpdateUi(string message, bool appendMessage = false, object someObject = null)
        {
            _synchronizationContext.Post(e =>
            {
                var display = appendMessage ? $"{txtResult.Text}{message}" : message;
                txtResult.Text = display;
            }, someObject);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBasicSort_Click(object sender, EventArgs e)
        {
            var cArray = new CArray(this, 10, true);
            cArray.DisplayElements();
            cArray.SelectionSort();
            cArray.DisplayElements();
        }
    }
}