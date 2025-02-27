// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// Preconditions must be fulfilled before an operation (update, delete, etc.) is
        /// carried out.
    /// </summary>
    public partial class V1Preconditions
    {
        /// <summary>
        /// Initializes a new instance of the V1Preconditions class.
        /// </summary>
        public V1Preconditions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Preconditions class.
        /// </summary>
        /// <param name="resourceVersion">
        /// Specifies the target ResourceVersion
        /// </param>
        /// <param name="uid">
        /// Specifies the target UID.
        /// </param>
        public V1Preconditions(string resourceVersion = null, string uid = null)
        {
            ResourceVersion = resourceVersion;
            Uid = uid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Specifies the target ResourceVersion
        /// </summary>
        [JsonProperty(PropertyName = "resourceVersion")]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// Specifies the target UID.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
