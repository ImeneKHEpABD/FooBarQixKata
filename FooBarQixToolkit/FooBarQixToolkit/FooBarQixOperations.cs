using NLog;
using System;

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

            if (Int64.TryParse(inputString, out parsedNumber))
            {
                result = foobarqixruledividers.ApplyRule(inputString);
                result += foobarqixrulecontains.ApplyRule(inputString);
            }
            else
            {
                logger.Error($"The input value [{parsedNumber}] is not a valid number");
            }
            return result;
        }
    }
}
