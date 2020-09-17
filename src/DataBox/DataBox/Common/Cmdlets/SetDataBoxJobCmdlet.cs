// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.DataBox;
using Microsoft.Azure.Management.DataBox.Models;
using Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models;
using System.Management.Automation;
using Resource = Microsoft.Azure.PowerShell.Cmdlets.DataBox.Resources.Resource;

namespace Microsoft.Azure.Commands.DataBox.Common
{
    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DataBoxJob", SupportsShouldProcess = true, DefaultParameterSetName = DataBoxEncryptionParameterSet), OutputType(typeof(PSDataBoxJob))]
    public class SetDataBoxJobCmdlet : AzureDataBoxCmdletBase
    {
        /// <summary>
        /// Storage Encryption parameter set name
        /// </summary>
        private const string DataBoxEncryptionParameterSet = "DataBoxDefaultEncryption";

        /// <summary>
        /// Keyvault Encryption parameter set name
        /// </summary>
        private const string KeyvaultEncryptionParameterSet = "KeyvaultEncryption";

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(HelpMessage = "Whether to set databox job encryption keySource to Microsoft.Keyvault or not. " +
            "If you specify KeyId and KeyvaultResourceId, Default Encryption KeySource will also be set to Microsoft.Keyvault weather this parameter is set or not.",
            Mandatory = false, ParameterSetName = KeyvaultEncryptionParameterSet)]
        public SwitchParameter KeyvaultEncryption
        {
            get { return keyvaultEncryption; }
            set { keyvaultEncryption = value; }
        }
        private bool keyvaultEncryption = false;

        [Parameter(HelpMessage = "DataBox job encryption keySource keyvault resource id",
                    Mandatory = true,
                    ParameterSetName = KeyvaultEncryptionParameterSet)]
        [ValidateNotNullOrEmpty]
        public string KeyVaultResourceID { get; set; }

        [Parameter(HelpMessage = "DataBox job encryption keySource KeyVault KeyId",
        Mandatory = true,
        ParameterSetName = KeyvaultEncryptionParameterSet)]
        [ValidateNotNullOrEmpty]
        public string KeyId
        {
            get; set;
        }

        [Parameter(
        Mandatory = false,
        HelpMessage = "Generate and assign a new Identity for this Databox job for use with key management services like Azure KeyVault.")]
        public SwitchParameter AssignIdentity { get; set; }


        public override void ExecuteCmdlet()
        {
            if (ShouldProcess(this.Name, string.Format(Resource.UpdatingDataboxJob + this.Name + Resource.InResourceGroup + this.ResourceGroupName)))
            {
                if (AssignIdentity.IsPresent)
                {
                    string identityType = "SystemAssigned";
                    Management.DataBox.Models.ResourceIdentity identity = new Management.DataBox.Models.ResourceIdentity(identityType);
                    var updateParams = new JobResourceUpdateParameter
                    {
                        Identity = identity
                    };
                    var updateJob = JobsOperationsExtensions.Update(DataBoxManagementClient.Jobs, ResourceGroupName, Name, updateParams);
                    WriteObject(new PSDataBoxJob(updateJob));
                }

                if (ParameterSetName == KeyvaultEncryptionParameterSet)
                {
                    var keyEncryptionKey = new KeyEncryptionKey(KekType.CustomerManaged)
                    {
                        KekUrl = KeyId,
                        KekVaultResourceID = KeyVaultResourceID 
                    };

                    var details = new UpdateJobDetails
                    {
                        KeyEncryptionKey = keyEncryptionKey
                    };

                    var updateParams = new JobResourceUpdateParameter
                    {
                        Details = details
                    };

                    var updateJob = JobsOperationsExtensions.Update(DataBoxManagementClient.Jobs, ResourceGroupName, Name, updateParams);
                    WriteObject(new PSDataBoxJob(updateJob));
                }
            }

        }
    }
}
