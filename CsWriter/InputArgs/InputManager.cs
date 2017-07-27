using System;
using System.Linq;
using System.Collections.Generic;

namespace CsWriter.InputArgs
{
    public class InputManager
    {
        public static InputManager I { get; set; } = new InputManager();

        private static readonly List<IArgument> Arguments = new List<IArgument>()
        {
            new Argument.Help(),
            new Argument.CsToJson()
        };

        public void LogMatching(string[] args)
        {
            foreach(string a in args)
            {
                foreach(var argument in Arguments.Where(arg => arg.Matches(a)))
                {
                    Console.WriteLine($"Matching arg {a} for {(argument.GetType().Name)}");
                }
            }
        }

        public List<Module.IModule> GetMatchingModules(string[] args){
            return Arguments.Where(arg => args.Any(a => arg.Matches(a)))
                            .Select(x => x.GetModule())
                            .ToList();
        }
    }
}


