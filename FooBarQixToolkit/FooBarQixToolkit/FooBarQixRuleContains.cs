using NLog;
using System;
using System.Collections.Generic;
using System.Text;


namespace FooBarQixToolkit
{
    public class FooBarQixRuleContains: FooBarQixAbstractRules
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
            int key;
            StringBuilder result = new StringBuilder();
            try
            {
                key = Int16.Parse(number);
                if (DicContainsRules.ContainsKey(key))
                    result.Append(DicContainsRules[key]);
                return result.ToString();
            }
            catch (Exception ex)
            {
                logger.Error("An error occurred in the FooBarQixRuleContains:ApplyRule method: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
