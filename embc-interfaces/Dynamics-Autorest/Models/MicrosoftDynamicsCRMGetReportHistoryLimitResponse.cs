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
    /// GetReportHistoryLimitResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMGetReportHistoryLimitResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetReportHistoryLimitResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetReportHistoryLimitResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMGetReportHistoryLimitResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMGetReportHistoryLimitResponse(int? historyLimit = default(int?))
        {
            HistoryLimit = historyLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HistoryLimit")]
        public int? HistoryLimit { get; set; }

    }
}
