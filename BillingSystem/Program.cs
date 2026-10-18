using System;
using System.Windows.Forms;
using PdfSharp;

namespace BillingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Register the free AGPL license for PDFsharp v6.5+
            PdfSharpLicense.SetAgplLicense();

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}