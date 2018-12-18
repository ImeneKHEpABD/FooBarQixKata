using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQixOperations
    {
        public FooBarQixRuleContains foobarqixrulecontains;
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public Dictionary<int, string> DicDividerRules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix"
        };

        public FooBarQixOperations()
        {
            foobarqixrulecontains = new FooBarQixRuleContains();
        }
        public string EvaluateRules(string inputString)
        {
            long parsedNumber = 0;
            var result = string.Empty;
            try
            {
                if (Int64.TryParse(inputString, out parsedNumber))
                {
                    result = ApplytheDeviderRule(parsedNumber);

                    result += BuildString(result, inputString);
                    if (string.IsNullOrEmpty(result))
                        result = inputString.ToString();
                }
                else
                {
                    logger.Error($"The input value [{parsedNumber}] is not a valid number");
                }
            }
            catch (Exception ex)
            {
                logger.Error("EvaluateRules Error: " + ex.Message);
            }
            return result;
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
                logger.Error("An error occurred in the ApplythedeviderRule method: " + ex.Message);
                return string.Empty;
            }
        }

        public string BuildString(string dividerresult, string number)
        {
            var result = string.Empty;
            try
            {
                if ((string.IsNullOrEmpty(dividerresult.Trim()))
                    && !number.Contains("3")
                    && !number.Contains("5")
                    && !number.Contains("7"))
                {
                    result = number.Replace('0', '*');
                }
                else
                {
                    result = number.Aggregate(result, (current, t) => current + foobarqixrulecontains.ApplytheContainsRule(t.ToString()));
                }
            }
            catch (Exception ex)
            {
                logger.Error("An error occurred in the BuildString method: " + ex.Message);
                result = string.Empty;
            }
            return result.ToString();
        }
    }
}
