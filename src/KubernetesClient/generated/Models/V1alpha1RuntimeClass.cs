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
    /// RuntimeClass defines a class of container runtime supported in the cluster. The
        /// RuntimeClass is used to determine which container runtime is used to run all
        /// containers in a pod. RuntimeClasses are (currently) manually defined by a user
        /// or cluster provisioner, and referenced in the PodSpec. The Kubelet is
        /// responsible for resolving the RuntimeClassName reference before running the pod.
        /// For more details, see
        /// https://git.k8s.io/enhancements/keps/sig-node/585-runtime-class
    /// </summary>
    public partial class V1alpha1RuntimeClass
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1RuntimeClass class.
        /// </summary>
        public V1alpha1RuntimeClass()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1RuntimeClass class.
        /// </summary>
        /// <param name="spec">
        /// Specification of the RuntimeClass More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
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
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </param>
        public V1alpha1RuntimeClass(V1alpha1RuntimeClassSpec spec, string apiVersion = null, string kind = null, V1ObjectMeta metadata = null)
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object.
        /// Servers should convert recognized schemas to the latest internal value, and may
        /// reject unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents.
        /// Servers may infer this from the endpoint the client submits requests to. Cannot
        /// be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Specification of the RuntimeClass More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public V1alpha1RuntimeClassSpec Spec { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Spec == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Spec");    
            }
            Metadata?.Validate();
            Spec?.Validate();
        }
    }
}
