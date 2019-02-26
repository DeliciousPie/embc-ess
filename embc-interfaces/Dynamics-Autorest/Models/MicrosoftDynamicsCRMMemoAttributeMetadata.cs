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
    /// MemoAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMMemoAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMMemoAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMMemoAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMMemoAttributeMetadata class.
        /// </summary>
        /// <param name="format">Possible values include: 'Email', 'Text',
        /// 'TextArea', 'Url', 'TickerSymbol', 'PhoneticGuide',
        /// 'VersionNumber', 'Phone'</param>
        /// <param name="imeMode">Possible values include: 'Auto', 'Inactive',
        /// 'Active', 'Disabled'</param>
        public MicrosoftDynamicsCRMMemoAttributeMetadata(string format = default(string), string imeMode = default(string), int? maxLength = default(int?), bool? isLocalizable = default(bool?))
        {
            Format = format;
            ImeMode = imeMode;
            MaxLength = maxLength;
            IsLocalizable = isLocalizable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Email', 'Text', 'TextArea',
        /// 'Url', 'TickerSymbol', 'PhoneticGuide', 'VersionNumber', 'Phone'
        /// </summary>
        [JsonProperty(PropertyName = "Format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Auto', 'Inactive', 'Active',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "ImeMode")]
        public string ImeMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxLength")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsLocalizable")]
        public bool? IsLocalizable { get; set; }

    }
}
