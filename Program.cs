using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GuidGen
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Guid g = System.Guid.NewGuid();

			string numer = "{" + g.ToString() + "}";
            System.Windows.Forms.Clipboard.SetText(numer);

            MessageBox.Show(
                string.Format("The following GUID has been generated:\n{0}.\n\nIt was also copied to clipboard; use Ctrl+V to paste it to your code.",
                numer), Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}