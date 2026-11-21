using LL.MDE.Components.Qvt.Common.DataModels;
using Newtonsoft.Json;
using System;
using System.IO;

namespace MDD4All.QVT.DataAccess.Default
{
    public class DefaultDomainJsonSerializer : IDomainJsonSerializer
    {
        public void SerializeToJsonFile(string path, Type type, object data)
        {
            string json = JsonConvert.SerializeObject(data,
                                                      Formatting.Indented,
                                                      new JsonSerializerSettings
                                                      {
                                                          NullValueHandling = NullValueHandling.Ignore,
                                                      });

            File.WriteAllText(path, json);
        }
    }
}
