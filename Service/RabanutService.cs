using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Rabanut.Configuration.RabanutConfiguration;
using static System.Windows.Forms.LinkLabel;
using Rabanut.Model;
using static Rabanut.Service.DateService;
namespace Rabanut.Service
{
    internal static class RabanutService
    {
        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(rabanutPath))
            {
                XDocument document = new();
                document.Add(new XElement("Queries"));
                document.Save(rabanutPath);
            }
        }
        public static XDocument ReedDocument() => XDocument.Load(rabanutPath);
        public static void SaveDocumentave(XDocument document) { document.Save(rabanutPath); }
        public static XElement ConverDateToXElement(DateModel date) =>
            new(
                "Query",
                new XElement("Day", date.DayInWeek),
                new XElement("DayMonth", date.DayInMonth),
                new XElement("Month", date.Month),
                new XElement("Year", date.Year),
                new XElement("Result", date.Result)
            );
        public static void AddQuery(DateModel date)
        {
            XDocument document = ReedDocument();
            document.Descendants("Queries")
                .First()
                .Add(ConverDateToXElement(date));
            SaveDocumentave(document);
        }
    }
}
