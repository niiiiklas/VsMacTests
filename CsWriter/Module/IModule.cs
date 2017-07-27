using System;
namespace CsWriter.Module
{
    public interface IModule
    {
        void Init(string[] args);

        void Start();

        string ResultPrint();
    }
}
