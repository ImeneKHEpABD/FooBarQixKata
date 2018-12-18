using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FooBarQixToolkit
{
    public class FooBarQixRuleContains : FooBarQixAbstractRules
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public Dictionary<int, string> DicContainsRules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix",
            [0] = "*"
        };

        public override string ApplyRule(string number)
        {
            long parsedNumber = 0;
            string result = string.Empty;   
            try
            {
                if (Int64.TryParse(number, out parsedNumber))
                {
                    if (parsedNumber % 3 != 0
                       && parsedNumber % 5 != 0
                       && parsedNumber % 7 != 0
                       && !number.Contains("3")
                        && !number.Contains("5")
                        && !number.Contains("7"))
                    {
                        result = number.Replace('0', '*');
                    }
                    else
                    {
                        result = number.Aggregate(result, (current, t) => current + ReturnDigitExpression(t.ToString()));
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                logger.Error("An error occurred in the FooBarQixRuleContains:ApplyRule method: " + ex.Message);
                return string.Empty;
            }     
        }

        public string ReturnDigitExpression(string number)
        {
            StringBuilder result = new StringBuilder();
            int key = Int16.Parse(number);

            if (DicContainsRules.ContainsKey(key))
                result.Append(DicContainsRules[key]);

            return result.ToString();
        }
    }
}
