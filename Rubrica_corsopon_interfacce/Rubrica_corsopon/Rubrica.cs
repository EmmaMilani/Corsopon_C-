using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rubrica_corsopon
{
    class Rubrica : IDictionary
    {
        Dictionary<IComparable, string> Numeri = new Dictionary<IComparable, string>();

        //implementazione metodi dell'interfaccia IDictionary
        public object find(IComparable key)
        {
            string value = "";
            if(Numeri.ContainsKey(key))
            {
                Numeri.TryGetValue(key, out value);
            }
            if (value != "")
                return value;
            else
                throw new Exception("La chiave non esiste");
        }

        public void insert(IComparable key, object value)
        {
            if(Numeri.ContainsKey(key))
            {
                Numeri[key] = (string)value;
            }
            else
                Numeri.Add((string)key, (string)value);
        }

        public bool isEmpty()
        {
            if (Numeri.Count >= 1)
                return true;
            else
                return false;
        }

        public void makeEmpty()
        {
            Numeri.Clear();
        }

        public void remove(IComparable key)
        {
            if (Numeri.ContainsKey((string)key))//se il valore c'è lo salvo sulla variabile attributo e ritorno true
            {
                Numeri.Remove((string)key);//rimuovo l'elemento key-value
            }
            else
                throw new Exception("La chiave non esiste");
        }

    class DictionaryItemNotFoundException { }
}
