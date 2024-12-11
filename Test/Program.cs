using System.Diagnostics;
using System.Xml;

namespace Test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<?xml version='1.0' ?>" +
                        "<book genre='novel' ISBN='1-861001-57-5'>" +
                        "<title>Pride And Prejudice</title>" +
                        "</book>");

            //Display the document element.
            Debug.WriteLine(doc.DocumentElement.OuterXml);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            
        }
    }
}