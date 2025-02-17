// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Common settings field for backup management
    /// </summary>
    public partial class Settings
    {
        /// <summary>
        /// Initializes a new instance of the Settings class.
        /// </summary>
        public Settings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Settings class.
        /// </summary>

        /// <param name="timeZone">TimeZone optional input as string. For example: TimeZone = &#34;Pacific
        /// Standard Time&#34;.
        /// </param>

        /// <param name="issqlcompression">SQL compression flag
        /// </param>

        /// <param name="isCompression">Workload compression flag. This has been added so that &#39;isSqlCompression&#39;
        /// will be deprecated once clients upgrade to consider this flag.
        /// </param>
        public Settings(string timeZone = default(string), bool? issqlcompression = default(bool?), bool? isCompression = default(bool?))

        {
            this.TimeZone = timeZone;
            this.Issqlcompression = issqlcompression;
            this.IsCompression = isCompression;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets timeZone optional input as string. For example: TimeZone =
        /// &#34;Pacific Standard Time&#34;.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeZone")]
        public string TimeZone {get; set; }

        /// <summary>
        /// Gets or sets sQL compression flag
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "issqlcompression")]
        public bool? Issqlcompression {get; set; }

        /// <summary>
        /// Gets or sets workload compression flag. This has been added so that
        /// &#39;isSqlCompression&#39;
        /// will be deprecated once clients upgrade to consider this flag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isCompression")]
        public bool? IsCompression {get; set; }
    }
}