/* 
 * Live Validation Service Client
 *
 * Client that can be used to access Live Validation Service.
 *
 * OpenAPI spec version: 1.0
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
    /// Live Request
    /// </summary>
    [DataContract]
    public partial class LiveRequest :  IEquatable<LiveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LiveRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LiveRequest" /> class.
        /// </summary>
        /// <param name="Method">Method of the Live Request. (required).</param>
        /// <param name="Url">Url of the Live Request. (required).</param>
        /// <param name="Body">Body of the Live Request.</param>
        /// <param name="Headers">Headers of the Live Request (required).</param>
        /// <param name="Query">Query Parameters of the Live Request.</param>
        public LiveRequest(string Method = default(string), string Url = default(string), Object Body = default(Object), Object Headers = default(Object), Object Query = default(Object))
        {
            // to ensure "Method" is required (not null)
            if (Method == null)
            {
                throw new InvalidDataException("Method is a required property for LiveRequest and cannot be null");
            }
            else
            {
                this.Method = Method;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for LiveRequest and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Headers" is required (not null)
            if (Headers == null)
            {
                throw new InvalidDataException("Headers is a required property for LiveRequest and cannot be null");
            }
            else
            {
                this.Headers = Headers;
            }
            this.Body = Body;
            this.Query = Query;
        }
        
        /// <summary>
        /// Method of the Live Request.
        /// </summary>
        /// <value>Method of the Live Request.</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }

        /// <summary>
        /// Url of the Live Request.
        /// </summary>
        /// <value>Url of the Live Request.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Body of the Live Request
        /// </summary>
        /// <value>Body of the Live Request</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public Object Body { get; set; }

        /// <summary>
        /// Headers of the Live Request
        /// </summary>
        /// <value>Headers of the Live Request</value>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public Object Headers { get; set; }

        /// <summary>
        /// Query Parameters of the Live Request
        /// </summary>
        /// <value>Query Parameters of the Live Request</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public Object Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveRequest {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as LiveRequest);
        }

        /// <summary>
        /// Returns true if LiveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LiveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LiveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Headers == input.Headers ||
                    (this.Headers != null &&
                    this.Headers.Equals(input.Headers))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
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
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
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
