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
    /// GetDistinctValuesImportFileResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMGetDistinctValuesImportFileResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetDistinctValuesImportFileResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetDistinctValuesImportFileResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetDistinctValuesImportFileResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetDistinctValuesImportFileResponse(IList<string> values = default(IList<string>))
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        [NotMapped] public IList<string> Values { get; set; }

    }
}
