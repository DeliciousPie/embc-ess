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
    /// msdyn_teamscollaboration
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynTeamscollaboration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynTeamscollaboration class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynTeamscollaboration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynTeamscollaboration class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynTeamscollaboration(int? statuscode = default(int?), string _organizationidValue = default(string), string msdynGroupid = default(string), string msdynTeamname = default(string), string _modifiedonbehalfbyValue = default(string), string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string msdynTenantid = default(string), int? importsequencenumber = default(int?), string msdynTeamsiteurl = default(string), string _modifiedbyValue = default(string), string regardingobjecttypename = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string msdynTeamid = default(string), int? utcconversiontimezonecode = default(int?), string msdynChannelfolderrelativeurl = default(string), string regardingobjectid = default(string), string msdynChannelname = default(string), string msdynChannelid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string msdynTeamscollaborationid = default(string), long? versionnumber = default(long?), int? regardingobjecttypecode = default(int?), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsyncerror> msdynTeamscollaborationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> msdynTeamscollaborationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> msdynTeamscollaborationMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> msdynTeamscollaborationProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> msdynTeamscollaborationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> msdynTeamscollaborationPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Statuscode = statuscode;
            this._organizationidValue = _organizationidValue;
            MsdynGroupid = msdynGroupid;
            MsdynTeamname = msdynTeamname;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            MsdynTenantid = msdynTenantid;
            Importsequencenumber = importsequencenumber;
            MsdynTeamsiteurl = msdynTeamsiteurl;
            this._modifiedbyValue = _modifiedbyValue;
            Regardingobjecttypename = regardingobjecttypename;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overriddencreatedon = overriddencreatedon;
            MsdynTeamid = msdynTeamid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            MsdynChannelfolderrelativeurl = msdynChannelfolderrelativeurl;
            Regardingobjectid = regardingobjectid;
            MsdynChannelname = msdynChannelname;
            MsdynChannelid = msdynChannelid;
            Modifiedon = modifiedon;
            MsdynTeamscollaborationid = msdynTeamscollaborationid;
            Versionnumber = versionnumber;
            Regardingobjecttypecode = regardingobjecttypecode;
            Statecode = statecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            MsdynTeamscollaborationSyncErrors = msdynTeamscollaborationSyncErrors;
            MsdynTeamscollaborationAsyncOperations = msdynTeamscollaborationAsyncOperations;
            MsdynTeamscollaborationMailboxTrackingFolders = msdynTeamscollaborationMailboxTrackingFolders;
            MsdynTeamscollaborationProcessSession = msdynTeamscollaborationProcessSession;
            MsdynTeamscollaborationBulkDeleteFailures = msdynTeamscollaborationBulkDeleteFailures;
            MsdynTeamscollaborationPrincipalObjectAttributeAccesses = msdynTeamscollaborationPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_groupid")]
        public string MsdynGroupid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamname")]
        public string MsdynTeamname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_tenantid")]
        public string MsdynTenantid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamsiteurl")]
        public string MsdynTeamsiteurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjecttypename")]
        public string Regardingobjecttypename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamid")]
        public string MsdynTeamid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_channelfolderrelativeurl")]
        public string MsdynChannelfolderrelativeurl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid")]
        public string Regardingobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_channelname")]
        public string MsdynChannelname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_channelid")]
        public string MsdynChannelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaborationid")]
        public string MsdynTeamscollaborationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjecttypecode")]
        public int? Regardingobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaboration_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> MsdynTeamscollaborationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaboration_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> MsdynTeamscollaborationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaboration_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MsdynTeamscollaborationMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaboration_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> MsdynTeamscollaborationProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaboration_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> MsdynTeamscollaborationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_teamscollaboration_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MsdynTeamscollaborationPrincipalObjectAttributeAccesses { get; set; }

    }
}
