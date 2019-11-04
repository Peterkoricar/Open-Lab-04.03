using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            string og = "";
            string om = "";
            
            if (original.Length < 2)
            {
                return original;
            }
                og = original.Remove(0,1);
                om = og.Remove(og.Length -1, 1);
                
               
            
            return om;
        }
    }
}
