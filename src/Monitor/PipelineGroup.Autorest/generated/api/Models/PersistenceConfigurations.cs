// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Extensions;

    /// <summary>Persistence options to all pipelines in the instance.</summary>
    public partial class PersistenceConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurations,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IPersistenceConfigurationsInternal
    {

        /// <summary>Backing field for <see cref="PersistentVolumeName" /> property.</summary>
        private string _persistentVolumeName;

        /// <summary>The name of the mounted persistent volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string PersistentVolumeName { get => this._persistentVolumeName; set => this._persistentVolumeName = value; }

        /// <summary>Creates an new <see cref="PersistenceConfigurations" /> instance.</summary>
        public PersistenceConfigurations()
        {

        }
    }
    /// Persistence options to all pipelines in the instance.
    public partial interface IPersistenceConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.IJsonSerializable
    {
        /// <summary>The name of the mounted persistent volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the mounted persistent volume.",
        SerializedName = @"persistentVolumeName",
        PossibleTypes = new [] { typeof(string) })]
        string PersistentVolumeName { get; set; }

    }
    /// Persistence options to all pipelines in the instance.
    internal partial interface IPersistenceConfigurationsInternal

    {
        /// <summary>The name of the mounted persistent volume.</summary>
        string PersistentVolumeName { get; set; }

    }
}