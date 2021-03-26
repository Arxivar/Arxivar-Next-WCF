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
    /// VariableBooleanConfigurationRm
    /// </summary>
    [DataContract]
        public partial class VariableBooleanConfigurationRm : VariabileConfigurationRm,  IEquatable<VariableBooleanConfigurationRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableBooleanConfigurationRm" /> class.
        /// </summary>
        /// <param name="defaultValue">The default value of the variable.</param>
        /// <param name="evaluateEvent">evaluateEvent.</param>
        public VariableBooleanConfigurationRm(bool? defaultValue = default(bool?), EvaluateEventRm evaluateEvent = default(EvaluateEventRm), int? variableType = default(int?), string name = default(string), bool? encryption = default(bool?), List<MultiLanguageValueRm> labels = default(List<MultiLanguageValueRm>), List<MultiLanguageValueRm> descriptions = default(List<MultiLanguageValueRm>), int? validationType = default(int?), string validationString = default(string), List<MultiLanguageValueRm> validationErrors = default(List<MultiLanguageValueRm>)) : base(variableType, name, encryption, labels, descriptions, validationType, validationString, validationErrors)
        {
            this.DefaultValue = defaultValue;
            this.EvaluateEvent = evaluateEvent;
        }
        
        /// <summary>
        /// The default value of the variable
        /// </summary>
        /// <value>The default value of the variable</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public bool? DefaultValue { get; set; }

        /// <summary>
        /// Gets or Sets EvaluateEvent
        /// </summary>
        [DataMember(Name="evaluateEvent", EmitDefaultValue=false)]
        public EvaluateEventRm EvaluateEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableBooleanConfigurationRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  EvaluateEvent: ").Append(EvaluateEvent).Append("\n");
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
            return this.Equals(input as VariableBooleanConfigurationRm);
        }

        /// <summary>
        /// Returns true if VariableBooleanConfigurationRm instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableBooleanConfigurationRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableBooleanConfigurationRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && base.Equals(input) && 
                (
                    this.EvaluateEvent == input.EvaluateEvent ||
                    (this.EvaluateEvent != null &&
                    this.EvaluateEvent.Equals(input.EvaluateEvent))
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
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.EvaluateEvent != null)
                    hashCode = hashCode * 59 + this.EvaluateEvent.GetHashCode();
                return hashCode;
            }
        }

    }
}