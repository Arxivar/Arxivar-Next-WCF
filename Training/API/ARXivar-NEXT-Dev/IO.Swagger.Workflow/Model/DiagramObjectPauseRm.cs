/* 
 * ARXivar Workflow API
 *
 * ARXivar Workflow API
 *
 * OpenAPI spec version: v1
 * Contact: info@abletech.it
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
using SwaggerDateConverter = IO.Swagger.Workflow.Client.SwaggerDateConverter;

namespace IO.Swagger.Workflow.Model
{
    /// <summary>
    /// DiagramObjectPauseRm
    /// </summary>
    [DataContract]
        public partial class DiagramObjectPauseRm : DiagramObjectRm,  IEquatable<DiagramObjectPauseRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramObjectPauseRm" /> class.
        /// </summary>
        /// <param name="interval">interval (required).</param>
        public DiagramObjectPauseRm(ObjectIntervalConfigurationRm interval = default(ObjectIntervalConfigurationRm), Guid? id = default(Guid?), Guid? diagramId = default(Guid?), int? objectType = default(int?)) : base(id, diagramId, objectType)
        {
            // to ensure "interval" is required (not null)
            if (interval == null)
            {
                throw new InvalidDataException("interval is a required property for DiagramObjectPauseRm and cannot be null");
            }
            else
            {
                this.Interval = interval;
            }
        }
        
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public ObjectIntervalConfigurationRm Interval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramObjectPauseRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DiagramObjectPauseRm);
        }

        /// <summary>
        /// Returns true if DiagramObjectPauseRm instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagramObjectPauseRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagramObjectPauseRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
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
                int hashCode = base.GetHashCode();
                if (this.Interval != null)
                    hashCode = hashCode * 59 + this.Interval.GetHashCode();
                return hashCode;
            }
        }

    }
}