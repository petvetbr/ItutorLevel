using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ItutorLevel
{
    public static class Config
    {
        private static Dictionary<int, Question> _lista;


        public static Question ObterPegunta(int numero)
        {
            _lista = _lista ?? LoadConfig();

            return _lista[numero];
        }
        static Dictionary<int, Question> LoadConfig()
        {
            var ret = new Dictionary<int, Question>();
            var assembly = typeof(Config).GetTypeInfo().Assembly;
            
            Stream stream = assembly.GetManifestResourceStream("Perguntas.xml");


            //List<Monkey> monkeys;
            //using (var reader = new System.IO.StreamReader(stream))
            //{
            //    var serializer = new XmlSerializer(typeof(List<Monkey>));
            //    monkeys = (List<Monkey>)serializer.Deserialize(reader);
            //}
            //var listView = new ListView();
            //listView.ItemsSource = monkeys;
            return ret;
        }
    }
}
