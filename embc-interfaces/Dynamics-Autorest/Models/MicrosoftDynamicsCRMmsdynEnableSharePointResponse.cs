// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// msdyn_EnableSharePointResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynEnableSharePointResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynEnableSharePointResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynEnableSharePointResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynEnableSharePointResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynEnableSharePointResponse(bool? operationResult = default(bool?))
        {
            OperationResult = operationResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OperationResult")]
        public bool? OperationResult { get; set; }

    }
}
