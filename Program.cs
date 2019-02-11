using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary eng = new Dictionary();
            eng.Plurals();
            eng.Replace();
            eng.NewWord();
            eng.CharacterLength();
            eng.Position();
            eng.Order();
            eng.ReverseArray();
        }
    }
}
