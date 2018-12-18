using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQixToolkit
{
    public class FooBarQixRuleDividers
    {
        private static Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public Dictionary<int, string> DicDividerRules = new Dictionary<int, string>
        {
            [3] = "Foo",
            [5] = "Bar",
            [7] = "Qix"
        };

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
    }
}
