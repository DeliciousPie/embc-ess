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
    /// WhoAmIResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMWhoAmIResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMWhoAmIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMWhoAmIResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMWhoAmIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMWhoAmIResponse(string businessUnitId = default(string), string userId = default(string), string organizationId = default(string))
        {
            BusinessUnitId = businessUnitId;
            UserId = userId;
            OrganizationId = organizationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessUnitId")]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrganizationId")]
        public string OrganizationId { get; set; }

    }
}
