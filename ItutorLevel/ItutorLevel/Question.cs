using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ItutorLevel
{
    public class Question:BindableObject
    {
        string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged(nameof(Text));
                }
            }
        }

        ObservableCollection<KeyValuePair<string, string>> _listaAlternativas;
        public ObservableCollection<KeyValuePair<string, string>> ListaAlternativas
        {
            get
            {
                return _listaAlternativas;
            }
            set
            {
                if (_listaAlternativas != value)
                {
                    _listaAlternativas = value;
                    OnPropertyChanged(nameof(ListaAlternativas));
                }
            }
        }
        QuestionType _tipo;
        public QuestionType Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                if (_tipo != value)
                {
                    _tipo = value;
                    OnPropertyChanged(nameof(Tipo));
                }
            }
        }
        string _resposta;
        public string Resposta
        {
            get
            {
                return _resposta;
            }
            set
            {
                if (_resposta != value)
                {
                    _resposta = value;
                    OnPropertyChanged(nameof(Resposta));
                }
            }
        }

        int _respostaMultipla;
        public int RespostaMultiplaAlternativas
        {
            get
            {
                return _respostaMultipla;
            }
            set
            {
                if (_respostaMultipla != value)
                {
                    _respostaMultipla = value;
                    OnPropertyChanged(nameof(RespostaMultiplaAlternativas));
                }
            }
        }

    }
    

    public enum QuestionType
    {
        MultiplaEscolha,
        Aberta
    }
}
