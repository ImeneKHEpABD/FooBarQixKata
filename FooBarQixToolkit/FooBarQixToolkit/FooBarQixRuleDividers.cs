using NLog;
using System;
using System.Collections.Generic;

namespace FooBarQixToolkit
{
    public class FooBarQixRuleDividers: FooBarQixAbstractRules
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public Dictionary<int, string> DicDividerRules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix"
        };

        public override string ApplyRule(string number)
        {
            long Number = 0;
            var result = string.Empty;
            if (Int64.TryParse(number, out Number))
            {
                try
                {
                    foreach (var val in DicDividerRules)
                    {
                        if (Number % val.Key == 0)
                            result += val.Value;
                    }
                }
                catch (Exception ex)
                {
                    logger.Error("FooBarQixRuleDividers:ApplyRule Error: " + ex.Message);
                }
            }
            return result;
        }
    }
}
