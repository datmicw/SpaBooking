using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookingSPA.Forms;

namespace BookingSPA
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Booking());
        }
    }
}
