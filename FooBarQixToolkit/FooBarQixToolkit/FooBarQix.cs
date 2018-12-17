using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQix
    {
        public Dictionary<int, string> DicDividerRules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix"
        };
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

            StringBuilder result = new StringBuilder();
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
                    foreach(char c in number)
                    {
                        if (c == '3')
                            result.Append("Foo");
                        if (c == '5')
                            result.Append("Bar");
                        if (c == '7')
                            result.Append("Qix");
                    }
                    return result.ToString();
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
                foreach (var val in DicDividerRules)
                {
                    if (number % val.Key == 0)
                        result += val.Value;
                }
                return result;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
