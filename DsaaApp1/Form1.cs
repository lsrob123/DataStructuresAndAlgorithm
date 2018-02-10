using System;
using System.Threading;
using System.Windows.Forms;
using DsaaApp1.Codes;

namespace DsaaApp1
{
    public partial class DsaaApp1 : Form, IUiUpdater
    {
        private readonly SynchronizationContext _synchronizationContext;

        public DsaaApp1()
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
    }
}