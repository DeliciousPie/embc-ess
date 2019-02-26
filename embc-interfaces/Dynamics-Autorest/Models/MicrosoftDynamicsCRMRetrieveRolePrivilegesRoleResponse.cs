// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// RetrieveRolePrivilegesRoleResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveRolePrivilegesRoleResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveRolePrivilegesRoleResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveRolePrivilegesRoleResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveRolePrivilegesRoleResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveRolePrivilegesRoleResponse(IList<MicrosoftDynamicsCRMRolePrivilege> rolePrivileges = default(IList<MicrosoftDynamicsCRMRolePrivilege>))
        {
            RolePrivileges = rolePrivileges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RolePrivileges")]
        [NotMapped] public IList<MicrosoftDynamicsCRMRolePrivilege> RolePrivileges { get; set; }

    }
}
