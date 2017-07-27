using System;
using CsWriter.Module;

namespace CsWriter.InputArgs.Argument
{
    public class Help : IArgument
    {
        public Help()
        {
        }

        public IModule GetModule()
        {
            return new Module.Help.HelpModule();
        }

        public bool Matches(string arg)
        {
            return arg == "h" || arg == "help";
        }
    }
}
