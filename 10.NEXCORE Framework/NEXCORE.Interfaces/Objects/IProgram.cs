using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace NEXCORE.Interfaces
{
    public interface IProgram
    {
        string Path { get; }
        string Name { get; }
        string Type { get; }
        string Description { get; }
        string Id { get; }

        void Initilize(Hashtable properties);
    }
}
