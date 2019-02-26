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
    /// site
    /// </summary>
    public partial class MicrosoftDynamicsCRMsite
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsite class.
        /// </summary>
        public MicrosoftDynamicsCRMsite()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsite class.
        /// </summary>
        public MicrosoftDynamicsCRMsite(string address1Telephone2 = default(string), string address2Line2 = default(string), string address1Fax = default(string), string address1Country = default(string), int? address2Addresstypecode = default(int?), int? timezonecode = default(int?), string address1Postofficebox = default(string), string address2Line3 = default(string), string address2Line1 = default(string), string address2Name = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string address1Telephone3 = default(string), string emailaddress = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string address1Postalcode = default(string), int? address1Utcoffset = default(int?), string address1Line2 = default(string), string address2Postofficebox = default(string), string address1City = default(string), string address2Country = default(string), string _organizationidValue = default(string), int? timezoneruleversionnumber = default(int?), int? address1Addresstypecode = default(int?), int? importsequencenumber = default(int?), string address1Line1 = default(string), string address2Telephone3 = default(string), string address2Telephone2 = default(string), string name = default(string), int? utcconversiontimezonecode = default(int?), string _createdonbehalfbyValue = default(string), double? address1Latitude = default(double?), string address1Line3 = default(string), string address1County = default(string), string _createdbyValue = default(string), string siteid = default(string), string address2City = default(string), int? address2Shippingmethodcode = default(int?), string address2Postalcode = default(string), string address1Stateorprovince = default(string), string address2Addressid = default(string), double? address2Latitude = default(double?), string address1Upszone = default(string), string address2County = default(string), int? address1Shippingmethodcode = default(int?), string address2Telephone1 = default(string), string address2Stateorprovince = default(string), string address1Telephone1 = default(string), string address1Name = default(string), double? address1Longitude = default(double?), string address1Addressid = default(string), string address2Upszone = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string address2Fax = default(string), string _modifiedbyValue = default(string), int? address2Utcoffset = default(int?), double? address2Longitude = default(double?), long? versionnumber = default(long?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationidOrganization = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMactivitypointer> siteActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> siteSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> siteAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> siteMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> siteProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> siteBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> sitePrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> siteAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> siteEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> siteFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> siteLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> sitePhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> siteTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> siteRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> siteSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMserviceappointment> siteServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMequipment> siteEquipment = default(IList<MicrosoftDynamicsCRMequipment>), IList<MicrosoftDynamicsCRMresource> siteResources = default(IList<MicrosoftDynamicsCRMresource>), IList<MicrosoftDynamicsCRMsystemuser> siteSystemUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), IList<MicrosoftDynamicsCRMserviceappointment> siteServiceAppointments1 = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMopportunityclose> siteOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> siteOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> siteQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>))
        {
            Address1Telephone2 = address1Telephone2;
            Address2Line2 = address2Line2;
            Address1Fax = address1Fax;
            Address1Country = address1Country;
            Address2Addresstypecode = address2Addresstypecode;
            Timezonecode = timezonecode;
            Address1Postofficebox = address1Postofficebox;
            Address2Line3 = address2Line3;
            Address2Line1 = address2Line1;
            Address2Name = address2Name;
            Createdon = createdon;
            Address1Telephone3 = address1Telephone3;
            Emailaddress = emailaddress;
            Overriddencreatedon = overriddencreatedon;
            Address1Postalcode = address1Postalcode;
            Address1Utcoffset = address1Utcoffset;
            Address1Line2 = address1Line2;
            Address2Postofficebox = address2Postofficebox;
            Address1City = address1City;
            Address2Country = address2Country;
            this._organizationidValue = _organizationidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Address1Addresstypecode = address1Addresstypecode;
            Importsequencenumber = importsequencenumber;
            Address1Line1 = address1Line1;
            Address2Telephone3 = address2Telephone3;
            Address2Telephone2 = address2Telephone2;
            Name = name;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Address1Latitude = address1Latitude;
            Address1Line3 = address1Line3;
            Address1County = address1County;
            this._createdbyValue = _createdbyValue;
            Siteid = siteid;
            Address2City = address2City;
            Address2Shippingmethodcode = address2Shippingmethodcode;
            Address2Postalcode = address2Postalcode;
            Address1Stateorprovince = address1Stateorprovince;
            Address2Addressid = address2Addressid;
            Address2Latitude = address2Latitude;
            Address1Upszone = address1Upszone;
            Address2County = address2County;
            Address1Shippingmethodcode = address1Shippingmethodcode;
            Address2Telephone1 = address2Telephone1;
            Address2Stateorprovince = address2Stateorprovince;
            Address1Telephone1 = address1Telephone1;
            Address1Name = address1Name;
            Address1Longitude = address1Longitude;
            Address1Addressid = address1Addressid;
            Address2Upszone = address2Upszone;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Address2Fax = address2Fax;
            this._modifiedbyValue = _modifiedbyValue;
            Address2Utcoffset = address2Utcoffset;
            Address2Longitude = address2Longitude;
            Versionnumber = versionnumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            OrganizationidOrganization = organizationidOrganization;
            SiteActivityPointers = siteActivityPointers;
            SiteSyncErrors = siteSyncErrors;
            SiteAsyncOperations = siteAsyncOperations;
            SiteMailboxTrackingFolders = siteMailboxTrackingFolders;
            SiteProcessSessions = siteProcessSessions;
            SiteBulkDeleteFailures = siteBulkDeleteFailures;
            SitePrincipalObjectAttributeAccesses = sitePrincipalObjectAttributeAccesses;
            SiteAppointments = siteAppointments;
            SiteEmails = siteEmails;
            SiteFaxes = siteFaxes;
            SiteLetters = siteLetters;
            SitePhoneCalls = sitePhoneCalls;
            SiteTasks = siteTasks;
            SiteRecurringAppointmentMasters = siteRecurringAppointmentMasters;
            SiteSocialActivities = siteSocialActivities;
            SiteServiceAppointments = siteServiceAppointments;
            SiteEquipment = siteEquipment;
            SiteResources = siteResources;
            SiteSystemUsers = siteSystemUsers;
            SiteServiceAppointments1 = siteServiceAppointments1;
            SiteOpportunityCloses = siteOpportunityCloses;
            SiteOrderCloses = siteOrderCloses;
            SiteQuoteCloses = siteQuoteCloses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_telephone2")]
        public string Address1Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_line2")]
        public string Address2Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_fax")]
        public string Address1Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_country")]
        public string Address1Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_addresstypecode")]
        public int? Address2Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezonecode")]
        public int? Timezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_postofficebox")]
        public string Address1Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_line3")]
        public string Address2Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_line1")]
        public string Address2Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_name")]
        public string Address2Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_telephone3")]
        public string Address1Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailaddress")]
        public string Emailaddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_postalcode")]
        public string Address1Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_utcoffset")]
        public int? Address1Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_line2")]
        public string Address1Line2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_postofficebox")]
        public string Address2Postofficebox { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_city")]
        public string Address1City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_country")]
        public string Address2Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_addresstypecode")]
        public int? Address1Addresstypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_line1")]
        public string Address1Line1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_telephone3")]
        public string Address2Telephone3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_telephone2")]
        public string Address2Telephone2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_latitude")]
        public double? Address1Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_line3")]
        public string Address1Line3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_county")]
        public string Address1County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "siteid")]
        public string Siteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_city")]
        public string Address2City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_shippingmethodcode")]
        public int? Address2Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_postalcode")]
        public string Address2Postalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_stateorprovince")]
        public string Address1Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_addressid")]
        public string Address2Addressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_latitude")]
        public double? Address2Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_upszone")]
        public string Address1Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_county")]
        public string Address2County { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_shippingmethodcode")]
        public int? Address1Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_telephone1")]
        public string Address2Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_stateorprovince")]
        public string Address2Stateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_telephone1")]
        public string Address1Telephone1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_name")]
        public string Address1Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_longitude")]
        public double? Address1Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address1_addressid")]
        public string Address1Addressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_upszone")]
        public string Address2Upszone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_fax")]
        public string Address2Fax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_utcoffset")]
        public int? Address2Utcoffset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address2_longitude")]
        public double? Address2Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

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
        [JsonProperty(PropertyName = "organizationid_organization")]
        public MicrosoftDynamicsCRMorganization OrganizationidOrganization { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_ActivityPointers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMactivitypointer> SiteActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Site_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> SiteSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Site_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> SiteAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SiteMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Site_ProcessSessions")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> SiteProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Site_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> SiteBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SitePrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_Appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMappointment> SiteAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_Emails")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> SiteEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_Faxes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfax> SiteFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_Letters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMletter> SiteLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_PhoneCalls")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonecall> SitePhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_Tasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtask> SiteTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_RecurringAppointmentMasters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SiteRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_SocialActivities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsocialactivity> SiteSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_ServiceAppointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> SiteServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_equipment")]
        [NotMapped] public IList<MicrosoftDynamicsCRMequipment> SiteEquipment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_resources")]
        [NotMapped] public IList<MicrosoftDynamicsCRMresource> SiteResources { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_system_users")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsystemuser> SiteSystemUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_service_appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMserviceappointment> SiteServiceAppointments1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_OpportunityCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunityclose> SiteOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_OrderCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMorderclose> SiteOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "site_QuoteCloses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMquoteclose> SiteQuoteCloses { get; set; }

    }
}
