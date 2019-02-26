// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Odataerrormain
    {
        /// <summary>
        /// Initializes a new instance of the Odataerrormain class.
        /// </summary>
        public Odataerrormain()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Odataerrormain class.
        /// </summary>
        /// <param name="innererror">The structure of this object is
        /// service-specific</param>
        public Odataerrormain(string code, string message, string target = default(string), IList<Odataerrordetail> details = default(IList<Odataerrordetail>), object innererror = default(object))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            Innererror = innererror;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [NotMapped] public IList<Odataerrordetail> Details { get; set; }

        /// <summary>
        /// Gets or sets the structure of this object is service-specific
        /// </summary>
        [JsonProperty(PropertyName = "innererror")]
        [NotMapped] public object Innererror { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
            if (Details != null)
            {
                foreach (var element in Details)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
