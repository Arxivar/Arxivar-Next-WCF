/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SharingHtmlDTO
    /// </summary>
    [DataContract]
    public partial class SharingHtmlDTO :  IEquatable<SharingHtmlDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingHtmlDTO" /> class.
        /// </summary>
        /// <param name="htmlKind">Possible values:  0: Access  1: Expiration .</param>
        /// <param name="header">Header.</param>
        /// <param name="bodyHeader">Body Header..</param>
        /// <param name="bodyContent">Body Content..</param>
        /// <param name="bodyFooter">Body footer..</param>
        /// <param name="footer">Footer.</param>
        /// <param name="lang">Lang Code..</param>
        public SharingHtmlDTO(int? htmlKind = default(int?), string header = default(string), string bodyHeader = default(string), string bodyContent = default(string), string bodyFooter = default(string), string footer = default(string), string lang = default(string))
        {
            this.HtmlKind = htmlKind;
            this.Header = header;
            this.BodyHeader = bodyHeader;
            this.BodyContent = bodyContent;
            this.BodyFooter = bodyFooter;
            this.Footer = footer;
            this.Lang = lang;
        }
        
        /// <summary>
        /// Possible values:  0: Access  1: Expiration 
        /// </summary>
        /// <value>Possible values:  0: Access  1: Expiration </value>
        [DataMember(Name="htmlKind", EmitDefaultValue=false)]
        public int? HtmlKind { get; set; }

        /// <summary>
        /// Header
        /// </summary>
        /// <value>Header</value>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public string Header { get; set; }

        /// <summary>
        /// Body Header.
        /// </summary>
        /// <value>Body Header.</value>
        [DataMember(Name="bodyHeader", EmitDefaultValue=false)]
        public string BodyHeader { get; set; }

        /// <summary>
        /// Body Content.
        /// </summary>
        /// <value>Body Content.</value>
        [DataMember(Name="bodyContent", EmitDefaultValue=false)]
        public string BodyContent { get; set; }

        /// <summary>
        /// Body footer.
        /// </summary>
        /// <value>Body footer.</value>
        [DataMember(Name="bodyFooter", EmitDefaultValue=false)]
        public string BodyFooter { get; set; }

        /// <summary>
        /// Footer
        /// </summary>
        /// <value>Footer</value>
        [DataMember(Name="footer", EmitDefaultValue=false)]
        public string Footer { get; set; }

        /// <summary>
        /// Lang Code.
        /// </summary>
        /// <value>Lang Code.</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingHtmlDTO {\n");
            sb.Append("  HtmlKind: ").Append(HtmlKind).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  BodyHeader: ").Append(BodyHeader).Append("\n");
            sb.Append("  BodyContent: ").Append(BodyContent).Append("\n");
            sb.Append("  BodyFooter: ").Append(BodyFooter).Append("\n");
            sb.Append("  Footer: ").Append(Footer).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SharingHtmlDTO);
        }

        /// <summary>
        /// Returns true if SharingHtmlDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingHtmlDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingHtmlDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HtmlKind == input.HtmlKind ||
                    (this.HtmlKind != null &&
                    this.HtmlKind.Equals(input.HtmlKind))
                ) && 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.BodyHeader == input.BodyHeader ||
                    (this.BodyHeader != null &&
                    this.BodyHeader.Equals(input.BodyHeader))
                ) && 
                (
                    this.BodyContent == input.BodyContent ||
                    (this.BodyContent != null &&
                    this.BodyContent.Equals(input.BodyContent))
                ) && 
                (
                    this.BodyFooter == input.BodyFooter ||
                    (this.BodyFooter != null &&
                    this.BodyFooter.Equals(input.BodyFooter))
                ) && 
                (
                    this.Footer == input.Footer ||
                    (this.Footer != null &&
                    this.Footer.Equals(input.Footer))
                ) && 
                (
                    this.Lang == input.Lang ||
                    (this.Lang != null &&
                    this.Lang.Equals(input.Lang))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.HtmlKind != null)
                    hashCode = hashCode * 59 + this.HtmlKind.GetHashCode();
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.BodyHeader != null)
                    hashCode = hashCode * 59 + this.BodyHeader.GetHashCode();
                if (this.BodyContent != null)
                    hashCode = hashCode * 59 + this.BodyContent.GetHashCode();
                if (this.BodyFooter != null)
                    hashCode = hashCode * 59 + this.BodyFooter.GetHashCode();
                if (this.Footer != null)
                    hashCode = hashCode * 59 + this.Footer.GetHashCode();
                if (this.Lang != null)
                    hashCode = hashCode * 59 + this.Lang.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}