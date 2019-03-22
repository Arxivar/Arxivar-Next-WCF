/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
    /// FieldsMatrixModuleDTO
    /// </summary>
    [DataContract]
    public partial class FieldsMatrixModuleDTO :  IEquatable<FieldsMatrixModuleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsMatrixModuleDTO" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="IdModel">Identificativo del modello office di riferimento..</param>
        /// <param name="ModelField">Nome del campo nel modello office..</param>
        /// <param name="ProfileField">Nome del campo di profilo..</param>
        /// <param name="Position">Indica la posizione della colonna all&#39;interno della tabella.</param>
        /// <param name="Label">Descrizione campo di ARXivar.</param>
        public FieldsMatrixModuleDTO(int? Id = default(int?), int? IdModel = default(int?), string ModelField = default(string), string ProfileField = default(string), int? Position = default(int?), string Label = default(string))
        {
            this.Id = Id;
            this.IdModel = IdModel;
            this.ModelField = ModelField;
            this.ProfileField = ProfileField;
            this.Position = Position;
            this.Label = Label;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Identificativo del modello office di riferimento.
        /// </summary>
        /// <value>Identificativo del modello office di riferimento.</value>
        [DataMember(Name="idModel", EmitDefaultValue=false)]
        public int? IdModel { get; set; }

        /// <summary>
        /// Nome del campo nel modello office.
        /// </summary>
        /// <value>Nome del campo nel modello office.</value>
        [DataMember(Name="modelField", EmitDefaultValue=false)]
        public string ModelField { get; set; }

        /// <summary>
        /// Nome del campo di profilo.
        /// </summary>
        /// <value>Nome del campo di profilo.</value>
        [DataMember(Name="profileField", EmitDefaultValue=false)]
        public string ProfileField { get; set; }

        /// <summary>
        /// Indica la posizione della colonna all&#39;interno della tabella
        /// </summary>
        /// <value>Indica la posizione della colonna all&#39;interno della tabella</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int? Position { get; set; }

        /// <summary>
        /// Descrizione campo di ARXivar
        /// </summary>
        /// <value>Descrizione campo di ARXivar</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldsMatrixModuleDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdModel: ").Append(IdModel).Append("\n");
            sb.Append("  ModelField: ").Append(ModelField).Append("\n");
            sb.Append("  ProfileField: ").Append(ProfileField).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as FieldsMatrixModuleDTO);
        }

        /// <summary>
        /// Returns true if FieldsMatrixModuleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldsMatrixModuleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldsMatrixModuleDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IdModel == input.IdModel ||
                    (this.IdModel != null &&
                    this.IdModel.Equals(input.IdModel))
                ) && 
                (
                    this.ModelField == input.ModelField ||
                    (this.ModelField != null &&
                    this.ModelField.Equals(input.ModelField))
                ) && 
                (
                    this.ProfileField == input.ProfileField ||
                    (this.ProfileField != null &&
                    this.ProfileField.Equals(input.ProfileField))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdModel != null)
                    hashCode = hashCode * 59 + this.IdModel.GetHashCode();
                if (this.ModelField != null)
                    hashCode = hashCode * 59 + this.ModelField.GetHashCode();
                if (this.ProfileField != null)
                    hashCode = hashCode * 59 + this.ProfileField.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
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