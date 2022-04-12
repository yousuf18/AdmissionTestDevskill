using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FrequencyCounter
    {
        public string Count(string text)
        {
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            StringBuilder sb = new StringBuilder();
            
            foreach (var item in text)
            {

                int ascii = item;
                if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122))
                {
                    if (ascii >= 97 && ascii <= 122)
                        ascii -= 32;
                    arr[ascii - 65]++;
                    
                }
            }
            sb.Clear();
            for (int i = 0; i < 26; i++)
            {
                if (arr[i] != 0)
                {
                    int ch = i + 65 + 32;
                   
                    sb.Append((char)ch);
                    sb.Append('-');
                    sb.Append(arr[i]);
                    sb.Append(',');
                   
                    
                }
            
            }
            return sb.ToString();

            
        }
    }
}
