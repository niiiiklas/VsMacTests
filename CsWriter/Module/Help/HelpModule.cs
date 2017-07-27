using System;
namespace CsWriter.Module.Help
{
    public class HelpModule : IModule
    {
        private string[] Args;

        public void Init(string[] args)
        {
            Args = Util.Do.Clone(args);
        }

        public string ResultPrint()
        {
            return @"
-- Welcome --
-h
-help
-cstojson [targetFile] [destinationFile] 

";
        }

        public void Start()
        {
            
        }
    }
}
