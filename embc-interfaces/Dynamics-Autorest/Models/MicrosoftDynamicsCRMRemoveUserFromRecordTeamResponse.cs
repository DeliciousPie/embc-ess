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
    /// RemoveUserFromRecordTeamResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRemoveUserFromRecordTeamResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRemoveUserFromRecordTeamResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRemoveUserFromRecordTeamResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRemoveUserFromRecordTeamResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRemoveUserFromRecordTeamResponse(string accessTeamId = default(string))
        {
            AccessTeamId = accessTeamId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessTeamId")]
        public string AccessTeamId { get; set; }

    }
}
