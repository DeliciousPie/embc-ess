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
    /// opportunitycompetitors
    /// </summary>
    public partial class MicrosoftDynamicsCRMopportunitycompetitors
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitycompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitycompetitors()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMopportunitycompetitors class.
        /// </summary>
        public MicrosoftDynamicsCRMopportunitycompetitors(int? timezoneruleversionnumber = default(int?), string competitorid = default(string), int? importsequencenumber = default(int?), string opportunityid = default(string), int? utcconversiontimezonecode = default(int?), long? versionnumber = default(long?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string opportunitycompetitorid = default(string), IList<MicrosoftDynamicsCRMasyncoperation> opportunitycompetitorsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> opportunitycompetitorsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> opportunitycompetitorsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> opportunitycompetitorsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Competitorid = competitorid;
            Importsequencenumber = importsequencenumber;
            Opportunityid = opportunityid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            Overriddencreatedon = overriddencreatedon;
            Opportunitycompetitorid = opportunitycompetitorid;
            OpportunitycompetitorsAsyncOperations = opportunitycompetitorsAsyncOperations;
            OpportunitycompetitorsMailboxTrackingFolders = opportunitycompetitorsMailboxTrackingFolders;
            OpportunitycompetitorsBulkDeleteFailures = opportunitycompetitorsBulkDeleteFailures;
            OpportunitycompetitorsPrincipalObjectAttributeAccesses = opportunitycompetitorsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitorid")]
        public string Competitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public string Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitorid")]
        public string Opportunitycompetitorid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> OpportunitycompetitorsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> OpportunitycompetitorsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> OpportunitycompetitorsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunitycompetitors_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> OpportunitycompetitorsPrincipalObjectAttributeAccesses { get; set; }

    }
}
