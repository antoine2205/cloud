using System;
using System.Runtime.Serialization;

namespace CoreApiModels
{
    [DataContract]
    public class Message<T>
    {
        [DataMember(Name = "version")]
        public string Version { get; set; }

        [DataMember(Name = "timestamp")]
        public string Timestamp { get; set; }

        [DataMember(Name = "station")]
        public T Station { get; set; }
    }
}
