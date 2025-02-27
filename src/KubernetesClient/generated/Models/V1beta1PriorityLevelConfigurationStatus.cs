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
    /// PriorityLevelConfigurationStatus represents the current state of a
        /// &quot;request-priority&quot;.
    /// </summary>
    public partial class V1beta1PriorityLevelConfigurationStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1PriorityLevelConfigurationStatus class.
        /// </summary>
        public V1beta1PriorityLevelConfigurationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1PriorityLevelConfigurationStatus class.
        /// </summary>
        /// <param name="conditions">
        /// `conditions` is the current state of &quot;request-priority&quot;.
        /// </param>
        public V1beta1PriorityLevelConfigurationStatus(IList<V1beta1PriorityLevelConfigurationCondition> conditions = null)
        {
            Conditions = conditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// `conditions` is the current state of &quot;request-priority&quot;.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V1beta1PriorityLevelConfigurationCondition> Conditions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null){
                foreach(var obj in Conditions)
                {
                    obj.Validate();
                }
            }
        }
    }
}
