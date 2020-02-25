using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Pizzaria
{
    class PFuncionario
    {
        private string arquivo = "c:\\temp\\funcionario.xml";
        List<MFuncionario> l = List<MFuncionario>() xml.Serialize(f);
        XmlSerializer xml = new XmlSerializer(typeof(List<MFuncionario>));
        StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
        xml.Serialize(f);
        f.Close();
        public void Insert(MFuncionario f)
        {
            List<MFuncionario> l = null;
            try
            {
                l = Insert(f);
            }
            catch
            {
                l = new List<MFuncionario>();
            }
            l.Add(f);
        }
    }
}
