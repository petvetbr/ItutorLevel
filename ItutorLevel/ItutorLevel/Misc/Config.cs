using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Linq;

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

            Stream stream = assembly.GetManifestResourceStream("ItutorLevel.Data.Perguntas.xml");

            var xml = XDocument.Load(stream);

            foreach (var p in xml.Root.Elements("Pergunta"))
            {
                int numero = int.Parse(p.Attribute("Numero").Value);
                var text = p.Attribute("Texto").Value;
                var tipo = (QuestionType)Enum.ToObject(typeof(QuestionType), int.Parse(p.Attribute("Tipo").Value));
                var opcoes = p.Elements().Select(x => new KeyValuePair<string, string>(x.Attribute("Opcao").Value, x.Value));
                var question = new Question()
                {
                    Numero = numero,
                    Text = text,
                    Tipo = tipo,
                    ListaAlternativas = new System.Collections.ObjectModel.ObservableCollection<KeyValuePair<string, string>>(opcoes)
                };
                ret.Add(numero, question);

            }
           
            return ret;
        }
    }
}
