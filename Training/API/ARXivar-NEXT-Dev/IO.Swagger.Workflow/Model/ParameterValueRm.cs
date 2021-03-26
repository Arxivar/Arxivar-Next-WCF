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
    /// Abstract class for set parameter value
    /// </summary>
    [DataContract]
        public partial class ParameterValueRm :  IEquatable<ParameterValueRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValueRm" /> class.
        /// </summary>
        /// <param name="kind">Parameter Value Kind [0&#x3D;Variable, 1&#x3D;Formula].</param>
        public ParameterValueRm(int? kind = default(int?))
        {
            this.Kind = kind;
        }
        
        /// <summary>
        /// Parameter Value Kind [0&#x3D;Variable, 1&#x3D;Formula]
        /// </summary>
        /// <value>Parameter Value Kind [0&#x3D;Variable, 1&#x3D;Formula]</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public int? Kind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParameterValueRm {\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
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
            return this.Equals(input as ParameterValueRm);
        }

        /// <summary>
        /// Returns true if ParameterValueRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ParameterValueRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParameterValueRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
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
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                return hashCode;
            }
        }

    }
}