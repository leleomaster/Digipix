using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipix.Infrastructure.Service
{
    public static class JsonConvertService<T>
    {
        public static T Deserialize(string obj)
        {
            var result = JsonConvert.DeserializeObject<T>(obj);
            return result;
        }

        public static string Serialize(object obj)
        {
            var result = JsonConvert.SerializeObject(obj);
            return result;
        }
    }
}
