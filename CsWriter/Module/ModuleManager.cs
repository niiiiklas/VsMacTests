using System;
using System.Collections.Generic;

namespace CsWriter.Module
{
    public class ModuleManager
    {
        private List<IModule> Modules { get; set; } = new List<IModule>()
        {

        };

        public ModuleManager()
        {
        }
    }
}
