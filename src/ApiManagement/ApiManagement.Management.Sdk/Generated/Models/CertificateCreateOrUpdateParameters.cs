// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Certificate create or update details.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CertificateCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CertificateCreateOrUpdateParameters class.
        /// </summary>
        public CertificateCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateCreateOrUpdateParameters class.
        /// </summary>

        /// <param name="data">Base 64 encoded certificate using the application/x-pkcs12 representation.
        /// </param>

        /// <param name="password">Password for the Certificate
        /// </param>

        /// <param name="keyVault">KeyVault location details of the certificate.
        /// </param>
        public CertificateCreateOrUpdateParameters(string data = default(string), string password = default(string), KeyVaultContractCreateProperties keyVault = default(KeyVaultContractCreateProperties))

        {
            this.Data = data;
            this.Password = password;
            this.KeyVault = keyVault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets base 64 encoded certificate using the application/x-pkcs12
        /// representation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.data")]
        public string Data {get; set; }

        /// <summary>
        /// Gets or sets password for the Certificate
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.password")]
        public string Password {get; set; }

        /// <summary>
        /// Gets or sets keyVault location details of the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyVault")]
        public KeyVaultContractCreateProperties KeyVault {get; set; }
    }
}