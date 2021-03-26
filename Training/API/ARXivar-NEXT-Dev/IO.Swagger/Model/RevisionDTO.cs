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
    /// Class of revision
    /// </summary>
    [DataContract]
    public partial class RevisionDTO :  IEquatable<RevisionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevisionDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="docnumber">Document Identifier.</param>
        /// <param name="revision">Revision Number.</param>
        /// <param name="user">User Identifier.</param>
        /// <param name="userDescription">User Description.</param>
        /// <param name="documentDate">Document Date.</param>
        /// <param name="profileDate">Document Creation Date.</param>
        /// <param name="path">File Path.</param>
        /// <param name="fileName">File Compressed Name.</param>
        /// <param name="originalName">Original File Name.</param>
        /// <param name="fileDate">File Date.</param>
        /// <param name="attachments">Has Attachments.</param>
        /// <param name="hash">File Hash.</param>
        /// <param name="zipPassword">Password Zip.</param>
        /// <param name="device">Possible values:  0: Hd  1: Cd .</param>
        /// <param name="cdLabel">CD Label.</param>
        /// <param name="cstring">Database to save.</param>
        /// <param name="saveType">Possible values:  0: File_System  1: Database .</param>
        /// <param name="compressed">If file compressed.</param>
        /// <param name="compressionMode">Possible values:  0: None  1: CompressChilkat91  2: CompressChilkat95  3: CompressChilkat95AndCryptoAes256 .</param>
        public RevisionDTO(int? id = default(int?), int? docnumber = default(int?), int? revision = default(int?), int? user = default(int?), string userDescription = default(string), DateTime? documentDate = default(DateTime?), DateTime? profileDate = default(DateTime?), string path = default(string), string fileName = default(string), string originalName = default(string), DateTime? fileDate = default(DateTime?), bool? attachments = default(bool?), string hash = default(string), string zipPassword = default(string), int? device = default(int?), string cdLabel = default(string), string cstring = default(string), int? saveType = default(int?), bool? compressed = default(bool?), int? compressionMode = default(int?))
        {
            this.Id = id;
            this.Docnumber = docnumber;
            this.Revision = revision;
            this.User = user;
            this.UserDescription = userDescription;
            this.DocumentDate = documentDate;
            this.ProfileDate = profileDate;
            this.Path = path;
            this.FileName = fileName;
            this.OriginalName = originalName;
            this.FileDate = fileDate;
            this.Attachments = attachments;
            this.Hash = hash;
            this.ZipPassword = zipPassword;
            this.Device = device;
            this.CdLabel = cdLabel;
            this.Cstring = cstring;
            this.SaveType = saveType;
            this.Compressed = compressed;
            this.CompressionMode = compressionMode;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Revision Number
        /// </summary>
        /// <value>Revision Number</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// User Description
        /// </summary>
        /// <value>User Description</value>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Document Date
        /// </summary>
        /// <value>Document Date</value>
        [DataMember(Name="documentDate", EmitDefaultValue=false)]
        public DateTime? DocumentDate { get; set; }

        /// <summary>
        /// Document Creation Date
        /// </summary>
        /// <value>Document Creation Date</value>
        [DataMember(Name="profileDate", EmitDefaultValue=false)]
        public DateTime? ProfileDate { get; set; }

        /// <summary>
        /// File Path
        /// </summary>
        /// <value>File Path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// File Compressed Name
        /// </summary>
        /// <value>File Compressed Name</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Original File Name
        /// </summary>
        /// <value>Original File Name</value>
        [DataMember(Name="originalName", EmitDefaultValue=false)]
        public string OriginalName { get; set; }

        /// <summary>
        /// File Date
        /// </summary>
        /// <value>File Date</value>
        [DataMember(Name="fileDate", EmitDefaultValue=false)]
        public DateTime? FileDate { get; set; }

        /// <summary>
        /// Has Attachments
        /// </summary>
        /// <value>Has Attachments</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public bool? Attachments { get; set; }

        /// <summary>
        /// File Hash
        /// </summary>
        /// <value>File Hash</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Password Zip
        /// </summary>
        /// <value>Password Zip</value>
        [DataMember(Name="zipPassword", EmitDefaultValue=false)]
        public string ZipPassword { get; set; }

        /// <summary>
        /// Possible values:  0: Hd  1: Cd 
        /// </summary>
        /// <value>Possible values:  0: Hd  1: Cd </value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public int? Device { get; set; }

        /// <summary>
        /// CD Label
        /// </summary>
        /// <value>CD Label</value>
        [DataMember(Name="cdLabel", EmitDefaultValue=false)]
        public string CdLabel { get; set; }

        /// <summary>
        /// Database to save
        /// </summary>
        /// <value>Database to save</value>
        [DataMember(Name="cstring", EmitDefaultValue=false)]
        public string Cstring { get; set; }

        /// <summary>
        /// Possible values:  0: File_System  1: Database 
        /// </summary>
        /// <value>Possible values:  0: File_System  1: Database </value>
        [DataMember(Name="saveType", EmitDefaultValue=false)]
        public int? SaveType { get; set; }

        /// <summary>
        /// If file compressed
        /// </summary>
        /// <value>If file compressed</value>
        [DataMember(Name="compressed", EmitDefaultValue=false)]
        public bool? Compressed { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: CompressChilkat91  2: CompressChilkat95  3: CompressChilkat95AndCryptoAes256 
        /// </summary>
        /// <value>Possible values:  0: None  1: CompressChilkat91  2: CompressChilkat95  3: CompressChilkat95AndCryptoAes256 </value>
        [DataMember(Name="compressionMode", EmitDefaultValue=false)]
        public int? CompressionMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RevisionDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
            sb.Append("  ProfileDate: ").Append(ProfileDate).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("  FileDate: ").Append(FileDate).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  ZipPassword: ").Append(ZipPassword).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  CdLabel: ").Append(CdLabel).Append("\n");
            sb.Append("  Cstring: ").Append(Cstring).Append("\n");
            sb.Append("  SaveType: ").Append(SaveType).Append("\n");
            sb.Append("  Compressed: ").Append(Compressed).Append("\n");
            sb.Append("  CompressionMode: ").Append(CompressionMode).Append("\n");
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
            return this.Equals(input as RevisionDTO);
        }

        /// <summary>
        /// Returns true if RevisionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RevisionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RevisionDTO input)
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
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.DocumentDate == input.DocumentDate ||
                    (this.DocumentDate != null &&
                    this.DocumentDate.Equals(input.DocumentDate))
                ) && 
                (
                    this.ProfileDate == input.ProfileDate ||
                    (this.ProfileDate != null &&
                    this.ProfileDate.Equals(input.ProfileDate))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                ) && 
                (
                    this.FileDate == input.FileDate ||
                    (this.FileDate != null &&
                    this.FileDate.Equals(input.FileDate))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    (this.Attachments != null &&
                    this.Attachments.Equals(input.Attachments))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.ZipPassword == input.ZipPassword ||
                    (this.ZipPassword != null &&
                    this.ZipPassword.Equals(input.ZipPassword))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.CdLabel == input.CdLabel ||
                    (this.CdLabel != null &&
                    this.CdLabel.Equals(input.CdLabel))
                ) && 
                (
                    this.Cstring == input.Cstring ||
                    (this.Cstring != null &&
                    this.Cstring.Equals(input.Cstring))
                ) && 
                (
                    this.SaveType == input.SaveType ||
                    (this.SaveType != null &&
                    this.SaveType.Equals(input.SaveType))
                ) && 
                (
                    this.Compressed == input.Compressed ||
                    (this.Compressed != null &&
                    this.Compressed.Equals(input.Compressed))
                ) && 
                (
                    this.CompressionMode == input.CompressionMode ||
                    (this.CompressionMode != null &&
                    this.CompressionMode.Equals(input.CompressionMode))
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
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.DocumentDate != null)
                    hashCode = hashCode * 59 + this.DocumentDate.GetHashCode();
                if (this.ProfileDate != null)
                    hashCode = hashCode * 59 + this.ProfileDate.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.OriginalName != null)
                    hashCode = hashCode * 59 + this.OriginalName.GetHashCode();
                if (this.FileDate != null)
                    hashCode = hashCode * 59 + this.FileDate.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Hash != null)
                    hashCode = hashCode * 59 + this.Hash.GetHashCode();
                if (this.ZipPassword != null)
                    hashCode = hashCode * 59 + this.ZipPassword.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.CdLabel != null)
                    hashCode = hashCode * 59 + this.CdLabel.GetHashCode();
                if (this.Cstring != null)
                    hashCode = hashCode * 59 + this.Cstring.GetHashCode();
                if (this.SaveType != null)
                    hashCode = hashCode * 59 + this.SaveType.GetHashCode();
                if (this.Compressed != null)
                    hashCode = hashCode * 59 + this.Compressed.GetHashCode();
                if (this.CompressionMode != null)
                    hashCode = hashCode * 59 + this.CompressionMode.GetHashCode();
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