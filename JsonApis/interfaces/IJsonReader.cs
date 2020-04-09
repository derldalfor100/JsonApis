using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonApis.Interfaces
{
    public interface IJsonReader
    {
        T GetSerializedJSON<T>(string url) where T: new();
    }
}
