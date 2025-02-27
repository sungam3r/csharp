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
    /// CSINodeDriver holds information about the specification of one CSI driver
        /// installed on a node
    /// </summary>
    public partial class V1CSINodeDriver
    {
        /// <summary>
        /// Initializes a new instance of the V1CSINodeDriver class.
        /// </summary>
        public V1CSINodeDriver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CSINodeDriver class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the CSI driver that this object refers to. This MUST be the
        /// same name returned by the CSI GetPluginName() call for that driver.
        /// </param>
        /// <param name="nodeID">
        /// nodeID of the node from the driver point of view. This field enables Kubernetes
        /// to communicate with storage systems that do not share the same nomenclature for
        /// nodes. For example, Kubernetes may refer to a given node as &quot;node1&quot;, but the
        /// storage system may refer to the same node as &quot;nodeA&quot;. When Kubernetes issues a
        /// command to the storage system to attach a volume to a specific node, it can use
        /// this field to refer to the node name using the ID that the storage system will
        /// understand, e.g. &quot;nodeA&quot; instead of &quot;node1&quot;. This field is required.
        /// </param>
        /// <param name="allocatable">
        /// allocatable represents the volume resources of a node that are available for
        /// scheduling. This field is beta.
        /// </param>
        /// <param name="topologyKeys">
        /// topologyKeys is the list of keys supported by the driver. When a driver is
        /// initialized on a cluster, it provides a set of topology keys that it understands
        /// (e.g. &quot;company.com/zone&quot;, &quot;company.com/region&quot;). When a driver is initialized on
        /// a node, it provides the same topology keys along with values. Kubelet will
        /// expose these topology keys as labels on its own node object. When Kubernetes
        /// does topology aware provisioning, it can use this list to determine which labels
        /// it should retrieve from the node object and pass back to the driver. It is
        /// possible for different nodes to use different topology keys. This can be empty
        /// if driver does not support topology.
        /// </param>
        public V1CSINodeDriver(string name, string nodeID, V1VolumeNodeResources allocatable = null, IList<string> topologyKeys = null)
        {
            Allocatable = allocatable;
            Name = name;
            NodeID = nodeID;
            TopologyKeys = topologyKeys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// allocatable represents the volume resources of a node that are available for
        /// scheduling. This field is beta.
        /// </summary>
        [JsonProperty(PropertyName = "allocatable")]
        public V1VolumeNodeResources Allocatable { get; set; }

        /// <summary>
        /// This is the name of the CSI driver that this object refers to. This MUST be the
        /// same name returned by the CSI GetPluginName() call for that driver.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// nodeID of the node from the driver point of view. This field enables Kubernetes
        /// to communicate with storage systems that do not share the same nomenclature for
        /// nodes. For example, Kubernetes may refer to a given node as &quot;node1&quot;, but the
        /// storage system may refer to the same node as &quot;nodeA&quot;. When Kubernetes issues a
        /// command to the storage system to attach a volume to a specific node, it can use
        /// this field to refer to the node name using the ID that the storage system will
        /// understand, e.g. &quot;nodeA&quot; instead of &quot;node1&quot;. This field is required.
        /// </summary>
        [JsonProperty(PropertyName = "nodeID")]
        public string NodeID { get; set; }

        /// <summary>
        /// topologyKeys is the list of keys supported by the driver. When a driver is
        /// initialized on a cluster, it provides a set of topology keys that it understands
        /// (e.g. &quot;company.com/zone&quot;, &quot;company.com/region&quot;). When a driver is initialized on
        /// a node, it provides the same topology keys along with values. Kubelet will
        /// expose these topology keys as labels on its own node object. When Kubernetes
        /// does topology aware provisioning, it can use this list to determine which labels
        /// it should retrieve from the node object and pass back to the driver. It is
        /// possible for different nodes to use different topology keys. This can be empty
        /// if driver does not support topology.
        /// </summary>
        [JsonProperty(PropertyName = "topologyKeys")]
        public IList<string> TopologyKeys { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Allocatable?.Validate();
        }
    }
}
