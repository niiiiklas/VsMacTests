using System;
namespace CsWriter.InputArgs
{
    public interface IArgument
    {
        bool Matches(string arg);
        Module.IModule GetModule();
    }
}
