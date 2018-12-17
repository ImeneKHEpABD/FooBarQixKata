using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQix
    {
        public string Compute(string number)
        {
            long integer;
            var result = string.Empty;
            try
            {
                if (!Int64.TryParse(number, out integer))
                {
                    return string.Empty;
                }
                else
                {
                    result = ApplytheDeviderRule(integer);
                    result += ApplytheContainsRule(number);

                    if (string.IsNullOrEmpty(result))
                    {
                        result = number.ToString();
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string ApplytheContainsRule(string number)
        {
            string result = string.Empty;
            try
            {

                if (!number.Contains("3")
                    && !number.Contains("5")
                    && !number.Contains("7"))
                {
                    return string.Empty;
                }
                else
                {

                    return result;
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public string ApplytheDeviderRule(long number)
        {
            string result = string.Empty;
            try
            {
                if (number % 3 != 0
                       && number % 5 != 0
                       && number % 7 != 0)
                {
                    return string.Empty;
                }
                else
                {
                  
                    return result;
                }
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
