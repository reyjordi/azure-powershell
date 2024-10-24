// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    /// <summary>The mode of operation for computing feature importance.</summary>
    public partial struct FeatureImportanceMode :
        System.IEquatable<FeatureImportanceMode>
    {
        /// <summary>Disables computing feature importance within a signal.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode Disabled = @"Disabled";

        /// <summary>Enables computing feature importance within a signal.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="FeatureImportanceMode" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FeatureImportanceMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FeatureImportanceMode" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FeatureImportanceMode(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FeatureImportanceMode</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FeatureImportanceMode (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FeatureImportanceMode && Equals((FeatureImportanceMode)obj);
        }

        /// <summary>Creates an instance of the <see cref="FeatureImportanceMode"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FeatureImportanceMode(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FeatureImportanceMode</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FeatureImportanceMode</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FeatureImportanceMode</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FeatureImportanceMode" />.</param>

        public static implicit operator FeatureImportanceMode(string value)
        {
            return new FeatureImportanceMode(value);
        }

        /// <summary>Implicit operator to convert FeatureImportanceMode to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FeatureImportanceMode" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FeatureImportanceMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FeatureImportanceMode</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.FeatureImportanceMode e2)
        {
            return e2.Equals(e1);
        }
    }
}