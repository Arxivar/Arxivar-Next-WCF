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
    /// AccumulationPackageDocumentValidationDTO
    /// </summary>
    [DataContract]
    public partial class AccumulationPackageDocumentValidationDTO :  IEquatable<AccumulationPackageDocumentValidationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccumulationPackageDocumentValidationDTO" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Docnumber">Docnumber.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="Status">Possible values:  0: Error  1: Verify .</param>
        /// <param name="LastUpdate">LastUpdate.</param>
        /// <param name="Description">Description.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserDescription">UserDescription.</param>
        /// <param name="AccumulationPackageDescription">AccumulationPackageDescription.</param>
        public AccumulationPackageDocumentValidationDTO(int? Id = default(int?), int? Docnumber = default(int?), DateTime? CreationDate = default(DateTime?), int? Status = default(int?), DateTime? LastUpdate = default(DateTime?), string Description = default(string), int? UserId = default(int?), string UserDescription = default(string), string AccumulationPackageDescription = default(string))
        {
            this.Id = Id;
            this.Docnumber = Docnumber;
            this.CreationDate = CreationDate;
            this.Status = Status;
            this.LastUpdate = LastUpdate;
            this.Description = Description;
            this.UserId = UserId;
            this.UserDescription = UserDescription;
            this.AccumulationPackageDescription = AccumulationPackageDescription;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Docnumber
        /// </summary>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Possible values:  0: Error  1: Verify 
        /// </summary>
        /// <value>Possible values:  0: Error  1: Verify </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserDescription
        /// </summary>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Gets or Sets AccumulationPackageDescription
        /// </summary>
        [DataMember(Name="accumulationPackageDescription", EmitDefaultValue=false)]
        public string AccumulationPackageDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccumulationPackageDocumentValidationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  AccumulationPackageDescription: ").Append(AccumulationPackageDescription).Append("\n");
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
            return this.Equals(input as AccumulationPackageDocumentValidationDTO);
        }

        /// <summary>
        /// Returns true if AccumulationPackageDocumentValidationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AccumulationPackageDocumentValidationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccumulationPackageDocumentValidationDTO input)
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
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.AccumulationPackageDescription == input.AccumulationPackageDescription ||
                    (this.AccumulationPackageDescription != null &&
                    this.AccumulationPackageDescription.Equals(input.AccumulationPackageDescription))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.AccumulationPackageDescription != null)
                    hashCode = hashCode * 59 + this.AccumulationPackageDescription.GetHashCode();
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