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
    /// monthlyfiscalcalendar
    /// </summary>
    public partial class MicrosoftDynamicsCRMmonthlyfiscalcalendar
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMmonthlyfiscalcalendar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmonthlyfiscalcalendar class.
        /// </summary>
        public MicrosoftDynamicsCRMmonthlyfiscalcalendar(object month8 = default(object), object month12Base = default(object), object month10Base = default(object), object exchangerate = default(object), string _createdonbehalfbyValue = default(string), object month6Base = default(object), object month9 = default(object), object month9Base = default(object), int? fiscalperiodtype = default(int?), object month4Base = default(object), string _createdbyValue = default(string), object month12 = default(object), string userfiscalcalendarid = default(string), string _businessunitidValue = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), object month11Base = default(object), object month2 = default(object), string _modifiedbyValue = default(string), int? timezoneruleversionnumber = default(int?), object month7 = default(object), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), object month11 = default(object), System.DateTimeOffset? effectiveon = default(System.DateTimeOffset?), object month3Base = default(object), object month6 = default(object), object month8Base = default(object), object month7Base = default(object), object month10 = default(object), object month1 = default(object), object month2Base = default(object), object month5 = default(object), object month1Base = default(object), object month3 = default(object), object month5Base = default(object), string _modifiedonbehalfbyValue = default(string), string _transactioncurrencyidValue = default(string), string _salespersonidValue = default(string), object month4 = default(object), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser salespersonid = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> monthlyFiscalCalendarAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> monthlyFiscalCalendarBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Month8 = month8;
            Month12Base = month12Base;
            Month10Base = month10Base;
            Exchangerate = exchangerate;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Month6Base = month6Base;
            Month9 = month9;
            Month9Base = month9Base;
            Fiscalperiodtype = fiscalperiodtype;
            Month4Base = month4Base;
            this._createdbyValue = _createdbyValue;
            Month12 = month12;
            Userfiscalcalendarid = userfiscalcalendarid;
            this._businessunitidValue = _businessunitidValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            Month11Base = month11Base;
            Month2 = month2;
            this._modifiedbyValue = _modifiedbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Month7 = month7;
            Modifiedon = modifiedon;
            Month11 = month11;
            Effectiveon = effectiveon;
            Month3Base = month3Base;
            Month6 = month6;
            Month8Base = month8Base;
            Month7Base = month7Base;
            Month10 = month10;
            Month1 = month1;
            Month2Base = month2Base;
            Month5 = month5;
            Month1Base = month1Base;
            Month3 = month3;
            Month5Base = month5Base;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._salespersonidValue = _salespersonidValue;
            Month4 = month4;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Salespersonid = salespersonid;
            MonthlyFiscalCalendarAsyncOperations = monthlyFiscalCalendarAsyncOperations;
            Transactioncurrencyid = transactioncurrencyid;
            Createdby = createdby;
            MonthlyFiscalCalendarBulkDeleteFailures = monthlyFiscalCalendarBulkDeleteFailures;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month8")]
        [NotMapped] public object Month8 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month12_base")]
        [NotMapped] public object Month12Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month10_base")]
        [NotMapped] public object Month10Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        [NotMapped] public object Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month6_base")]
        [NotMapped] public object Month6Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month9")]
        [NotMapped] public object Month9 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month9_base")]
        [NotMapped] public object Month9Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fiscalperiodtype")]
        public int? Fiscalperiodtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month4_base")]
        [NotMapped] public object Month4Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month12")]
        [NotMapped] public object Month12 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userfiscalcalendarid")]
        public string Userfiscalcalendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_businessunitid_value")]
        public string _businessunitidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month11_base")]
        [NotMapped] public object Month11Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month2")]
        [NotMapped] public object Month2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month7")]
        [NotMapped] public object Month7 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month11")]
        [NotMapped] public object Month11 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveon")]
        public System.DateTimeOffset? Effectiveon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month3_base")]
        [NotMapped] public object Month3Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month6")]
        [NotMapped] public object Month6 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month8_base")]
        [NotMapped] public object Month8Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month7_base")]
        [NotMapped] public object Month7Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month10")]
        [NotMapped] public object Month10 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month1")]
        [NotMapped] public object Month1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month2_base")]
        [NotMapped] public object Month2Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month5")]
        [NotMapped] public object Month5 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month1_base")]
        [NotMapped] public object Month1Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month3")]
        [NotMapped] public object Month3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month5_base")]
        [NotMapped] public object Month5Base { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_salespersonid_value")]
        public string _salespersonidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "month4")]
        [NotMapped] public object Month4 { get; set; }

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
        [JsonProperty(PropertyName = "salespersonid")]
        public MicrosoftDynamicsCRMsystemuser Salespersonid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MonthlyFiscalCalendar_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> MonthlyFiscalCalendarAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MonthlyFiscalCalendar_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> MonthlyFiscalCalendarBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
