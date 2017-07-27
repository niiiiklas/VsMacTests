using System;

namespace CsWriter
{
    public class Start
    {
        public static void Go(params string[] arguments)
        {
            InputArgs.InputManager.I.LogMatching(arguments);

            //matching modules:
            var modules = InputArgs.InputManager.I.GetMatchingModules(arguments);

            //start modules
            foreach (var module in modules)
                module.Start();

            //log result
            foreach (var module in modules)
                Console.Write(module.ResultPrint());
        }
    }
}
