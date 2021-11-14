using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_homework
{
    public class personel
    {
        private string tc;

        public string tckimlik
        {
            get
            {
                return tc.Substring(0, 5) + "******";

            }
            set
            {
                bool control = false;

                if(value.Length == 11)
                {
                    for(int i = 0; i <value.Length; i++)
                    {
                        bool is_iterator_number = char.IsNumber(value[i]); //1234567584
                        if(is_iterator_number)
                        {
                            //yapmamız gereken birsey yok
                        }
                        else 
                        {
                            control = true;
                                break;
                        }
                        if(control)
                        {
                            Console.WriteLine("please use valid character.");
                        }
                        else
                        {
                            tc = value;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("your entry is not eleven character.");
                }
            }
        
        }
    }
}
