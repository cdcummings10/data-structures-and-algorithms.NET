using System;
using System.Collections.Generic;

namespace MultiBracketValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiBracketValidation("()[[Extra Characters]]");
        }

        public static bool MultiBracketValidation(string input)
        {
            List<char> storage = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                        storage.Add(input[i]);
                        break;
                    case '[':
                        storage.Add(input[i]);
                        break;
                    case '{':
                        storage.Add(input[i]);
                        break;
                    case ')':
                        if (storage[storage.Count - 1] != '(') { return false; }
                        else { storage.RemoveAt(storage.Count - 1); }
                        break;
                    case ']':
                        if (storage[storage.Count - 1] != '[') { return false; }
                        else { storage.RemoveAt(storage.Count - 1); }
                        break;
                    case '}':
                        if (storage[storage.Count - 1] != '{') { return false; }
                        else { storage.RemoveAt(storage.Count - 1); }
                        break;
                    default:
                        break;
                }
            }
            if ((input.Contains('[') || input.Contains('(') || input.Contains('{')) && storage.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
