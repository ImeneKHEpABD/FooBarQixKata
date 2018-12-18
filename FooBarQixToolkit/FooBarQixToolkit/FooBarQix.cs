using NLog;
using System;

namespace FooBarQixToolkit
{
    public class FooBarQix
    {
        private static Logger logger;
        private FooBarQixOperations foobarqixoperations;

        public FooBarQix(FooBarQixOperations opM)
        {
            logger = LogManager.GetCurrentClassLogger();
            logger.Info("Initialize FooBarQix Toolkit");
            foobarqixoperations = opM;
        }
        public string Compute(string number)
        {
            try
            {
                return foobarqixoperations.EvaluateRules(number);
            }
            catch (Exception ex)
            {
                logger.Error("An error occurred in the Compute method: " + ex.Message);
                return string.Empty;
            }
        }

        
    }
}
