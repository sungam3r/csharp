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
    /// EndpointSlice represents a subset of the endpoints that implement a service. For
        /// a given service there may be multiple EndpointSlice objects, selected by labels,
        /// which must be joined to produce the full set of endpoints.
    /// </summary>
    public partial class V1EndpointSlice
    {
        /// <summary>
        /// Initializes a new instance of the V1EndpointSlice class.
        /// </summary>
        public V1EndpointSlice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1EndpointSlice class.
        /// </summary>
        /// <param name="addressType">
        /// addressType specifies the type of address carried by this EndpointSlice. All
        /// addresses in this slice must be the same type. This field is immutable after
        /// creation. The following address types are currently supported: * IPv4:
        /// Represents an IPv4 Address. * IPv6: Represents an IPv6 Address. * FQDN:
        /// Represents a Fully Qualified Domain Name.
        /// </param>
        /// <param name="endpoints">
        /// endpoints is a list of unique endpoints in this slice. Each slice may include a
        /// maximum of 1000 endpoints.
        /// </param>
        /// <param name="apiVersion">
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </param>
        /// <param name="kind">
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </param>
        /// <param name="metadata">
        /// Standard object&apos;s metadata.
        /// </param>
        /// <param name="ports">
        /// ports specifies the list of network ports exposed by each endpoint in this
        /// slice. Each port must have a unique name. When ports is empty, it indicates that
        /// there are no defined ports. When a port is defined with a nil port value, it
        /// indicates &quot;all ports&quot;. Each slice may include a maximum of 100 ports.
        /// </param>
        public V1EndpointSlice(string addressType, IList<V1Endpoint> endpoints, string apiVersion = null, string kind = null, V1ObjectMeta metadata = null, IList<Discoveryv1EndpointPort> ports = null)
        {
            AddressType = addressType;
            ApiVersion = apiVersion;
            Endpoints = endpoints;
            Kind = kind;
            Metadata = metadata;
            Ports = ports;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// addressType specifies the type of address carried by this EndpointSlice. All
        /// addresses in this slice must be the same type. This field is immutable after
        /// creation. The following address types are currently supported: * IPv4:
        /// Represents an IPv4 Address. * IPv6: Represents an IPv6 Address. * FQDN:
        /// Represents a Fully Qualified Domain Name.
        /// </summary>
        [JsonProperty(PropertyName = "addressType")]
        public string AddressType { get; set; }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// endpoints is a list of unique endpoints in this slice. Each slice may include a
        /// maximum of 1000 endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<V1Endpoint> Endpoints { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object&apos;s metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// ports specifies the list of network ports exposed by each endpoint in this
        /// slice. Each port must have a unique name. When ports is empty, it indicates that
        /// there are no defined ports. When a port is defined with a nil port value, it
        /// indicates &quot;all ports&quot;. Each slice may include a maximum of 100 ports.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<Discoveryv1EndpointPort> Ports { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Endpoints != null){
                foreach(var obj in Endpoints)
                {
                    obj.Validate();
                }
            }
            Metadata?.Validate();
            if (Ports != null){
                foreach(var obj in Ports)
                {
                    obj.Validate();
                }
            }
        }
    }
}
