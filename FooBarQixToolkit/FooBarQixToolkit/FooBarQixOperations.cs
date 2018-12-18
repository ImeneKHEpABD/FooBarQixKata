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
        public FooBarQixRuleDividers foobarqixruledividers;
        private Logger logger = NLog.LogManager.GetCurrentClassLogger();
    
        public FooBarQixOperations()
        {
            foobarqixrulecontains = new FooBarQixRuleContains();
            foobarqixruledividers = new FooBarQixRuleDividers();
        }
        public string EvaluateRules(string inputString)
        {
            long parsedNumber = 0;
            var result = string.Empty;
            try
            {
                if (Int64.TryParse(inputString, out parsedNumber))
                {
                    result = foobarqixruledividers.ApplytheDeviderRule(parsedNumber);

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
                    result = number.Aggregate(result, (current, t) => current + foobarqixrulecontains.ApplyRule(t.ToString()));
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
