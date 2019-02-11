using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Dictionary
{
    class Dictionary
    {
        string[] Words = { "Boat", "House", "Cat", "River", "Cupboard" };

        public void Plurals()
        {
            Console.WriteLine("1. The plural forms are:");
            foreach (var word in Words)
            {
                Console.WriteLine(word + "s");
            }
        }
        public void Replace()
        {
            Words[1] = "Home";
            Console.WriteLine("\n2. After replacing:");
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
        }
        public void NewWord()
        {
            Array.Resize(ref Words, Words.Length + 1);
            Words[5] = "Dog";
            //Words.Add("Dog");
            Console.WriteLine("\n3. The length of the new list is :" + Words.Length);
            Console.WriteLine("\nAnd the new list is: ");
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
        }
        public void CharacterLength()
        {
            int flag = 0;

            foreach (var word in Words)
            {
                int len = word.Length;
                if (len == 7)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 1)
            {
                Console.WriteLine("\n4. The words having length of characters as 7, are:");
            }
            else
            {
                Console.WriteLine("\n4. There's no such word(s) with length of characters as 7.");
            }
        }
        public void Position()
        {
            Console.WriteLine("\n5. The element in the 3rd position is :" + Words[2]);
        }
        public void Order()
        {
            Array.Sort(Words);
            Console.WriteLine("\n6. The sorted list in ascending order is :");
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
        }
        public void ReverseArray()
        {
            Array.Reverse(Words);
            Console.WriteLine("\n7. The reversed list is :");
            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
