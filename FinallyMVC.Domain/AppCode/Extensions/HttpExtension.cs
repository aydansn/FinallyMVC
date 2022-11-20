using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOn.Domain.AppCode.Extensions
{
    public static partial class Extension
    {

        public static Dictionary<string, object> AddFromHeader(this Dictionary<string,object> items,
            HttpRequest request,string key)
        {
            if (request.Headers.TryGetValue(key, out StringValues values))
            {
                items.Add(key, values.FirstOrDefault());
            }

            return items;
        }
    }
}
