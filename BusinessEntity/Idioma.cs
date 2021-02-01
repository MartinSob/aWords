using System.Collections.Generic;

namespace BusinessEntity
{
    public class Idioma {
        public int id;
        public string nombre = "Castellano";
        public List<iUpdatable> forms = new List<iUpdatable>();
        public Dictionary<string, string> textos = new Dictionary<string, string>();
	}
}
