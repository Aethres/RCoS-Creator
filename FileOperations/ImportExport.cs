using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1.FileOperations
{
    public static class ImportExport
    {
        public static void ExportProcess(List<Process> a_stations, string a_fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Process>));

            using (var stream = File.OpenWrite(a_fileName))
            {
                serializer.Serialize(stream, a_stations);
            }
        }

        public static void ImportProcess<List>()
        {

        }
    }
}
