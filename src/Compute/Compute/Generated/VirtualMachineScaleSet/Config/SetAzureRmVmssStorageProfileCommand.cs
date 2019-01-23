//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssStorageProfile", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class SetAzureRmVmssStorageProfileCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferencePublisher { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceOffer { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceSku { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceVersion { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        [Alias("Name")]
        public string OsDiskName { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public CachingTypes? OsDiskCaching { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public string OsDiskCreateOption { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public OperatingSystemTypes? OsDiskOsType { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public string Image { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public string[] VhdContainer { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string ImageReferenceId { get; set; }

        [Parameter(
            Mandatory = false)]
        public SwitchParameter OsDiskWriteAccelerator { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public string DiffDiskSetting { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        [PSArgumentCompleter("Standard_LRS", "Premium_LRS", "StandardSSD_LRS", "UltraSSD_LRS")]
        public string ManagedDisk { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true)]
        public VirtualMachineScaleSetDataDisk[] DataDisk { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Set"))
            {
                Run();
            }
        }

        private void Run()
        {
            if (this.MyInvocation.BoundParameters.ContainsKey("ImageReferencePublisher"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Publisher = this.ImageReferencePublisher;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ImageReferenceOffer"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Offer = this.ImageReferenceOffer;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ImageReferenceSku"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Sku = this.ImageReferenceSku;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ImageReferenceVersion"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Version = this.ImageReferenceVersion;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ImageReferenceId"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // ImageReference
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference = new ImageReference();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.ImageReference.Id = this.ImageReferenceId;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("OsDiskName"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Name = this.OsDiskName;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("OsDiskCaching"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Caching = this.OsDiskCaching;
            }

            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
            }
            // StorageProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
            }
            // OsDisk
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
            }
            this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.WriteAcceleratorEnabled = this.OsDiskWriteAccelerator.IsPresent;

            if (this.MyInvocation.BoundParameters.ContainsKey("OsDiskCreateOption"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.CreateOption = this.OsDiskCreateOption;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("DiffDiskSetting"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // DiffDiskSettings
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings = new DiffDiskSettings();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.DiffDiskSettings.Option = this.DiffDiskSetting;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("OsDiskOsType"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.OsType = this.OsDiskOsType;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("Image"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // Image
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Image == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Image = new VirtualHardDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.Image.Uri = this.Image;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("VhdContainer"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.VhdContainers = this.VhdContainer;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("ManagedDisk"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                // OsDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk = new VirtualMachineScaleSetOSDisk();
                }
                // ManagedDisk
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk = new VirtualMachineScaleSetManagedDiskParameters();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.OsDisk.ManagedDisk.StorageAccountType = this.ManagedDisk;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("DataDisk"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new VirtualMachineScaleSetVMProfile();
                }
                // StorageProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile = new VirtualMachineScaleSetStorageProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.StorageProfile.DataDisks = this.DataDisk;
            }

            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
