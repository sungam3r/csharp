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
    /// NodeDaemonEndpoints lists ports opened by daemons running on the Node.
    /// </summary>
    public partial class V1NodeDaemonEndpoints
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeDaemonEndpoints class.
        /// </summary>
        public V1NodeDaemonEndpoints()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeDaemonEndpoints class.
        /// </summary>
        /// <param name="kubeletEndpoint">
        /// Endpoint on which Kubelet is listening.
        /// </param>
        public V1NodeDaemonEndpoints(V1DaemonEndpoint kubeletEndpoint = null)
        {
            KubeletEndpoint = kubeletEndpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Endpoint on which Kubelet is listening.
        /// </summary>
        [JsonProperty(PropertyName = "kubeletEndpoint")]
        public V1DaemonEndpoint KubeletEndpoint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            KubeletEndpoint?.Validate();
        }
    }
}
