using System;
using CsWriter.Module;

namespace CsWriter.InputArgs.Argument
{
    public class CsToJson : IArgument
    {
        public IModule GetModule()
        {
            return new Module.CsToJson.CsToJsonModule();
        }

        public bool Matches(string arg)
        {
            return arg == "cstojson";
        }
    }
}
