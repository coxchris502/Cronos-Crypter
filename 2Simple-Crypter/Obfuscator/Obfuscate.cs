﻿using _2Simple_Crypter.Obfuscator.Class;
using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Simple_Crypter.Obfuscator
{
    internal class Obfuscate
    {
        public void Execute(ModuleDefMD module)
        {
            ClassRandomization.Execute(module);
            ClassIncreaser.Execute(module);
        }
    }
}
