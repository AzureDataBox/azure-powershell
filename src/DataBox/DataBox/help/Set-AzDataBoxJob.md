---
external help file: Microsoft.Azure.PowerShell.Cmdlets.DataBox.dll-Help.xml
Module Name: Az.DataBox
online version:
schema: 2.0.0
---

# Set-AzDataBoxJob

## SYNOPSIS
Updates a databox job using the specified parameters.

## SYNTAX

### DataBoxDefaultEncryption (Default)
```
Set-AzDataBoxJob -ResourceGroupName <String> -Name <String> [-AssignIdentity]
 [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeyvaultEncryption
```
Set-AzDataBoxJob -ResourceGroupName <String> -Name <String> [-KeyvaultEncryption] -KeyVaultResourceID <String>
 -KeyId <String> [-AssignIdentity] [-DefaultProfile <IAzureContextContainer>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
The **Set-AzDataBoxJob** cmdlet is used to update a databox job to customer managed key or assign a identity to it.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-AzDataBoxJob -ResourceGroupName databoxbvt -Name TestUpdateJob -AssignIdentity

jobResource.Name jobResource.Sku.Name jobResource.Status jobResource.StartTime jobResource.Location ResourceGroup
---------------- -------------------- ------------------ --------------------- -------------------- -------------
TestupdateJob    DataBox              DeviceOrdered      15-09-2020 07:56:55   westus               databoxbvt
```

The cmdlet takes all the required parameters and some optional parameters to assign identity the databox job.

### Example 2
```powershell
PS C:\> Set-AzDataBoxJob -ResourceGroupName "databoxbvt"  -Name "TestUpdateJob" -KeyvaultEncryption  -KeyVaultResourceID $keyVault.ResourceId -KeyId $key.Id

jobResource.Name jobResource.Sku.Name jobResource.Status jobResource.StartTime jobResource.Location ResourceGroup
---------------- -------------------- ------------------ --------------------- -------------------- -------------
TestupdateJob    DataBox              DeviceOrdered      15-09-2020 07:56:55   westus               databoxbvt
```

The cmdlet takes all the required parameters and some optional parameters for updating a databox job to customer managed key.

## PARAMETERS

### -AssignIdentity
Generate and assign a new Identity for this Databox job for use with key management services like Azure KeyVault.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeyId
DataBox job encryption keySource KeyVault KeyId

```yaml
Type: System.String
Parameter Sets: KeyvaultEncryption
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeyvaultEncryption
Whether to set databox job encryption keySource to Microsoft.Keyvault or not.
If you specify KeyId and KeyvaultUri, Default Encryption KeySource will also be set to Microsoft.Keyvault weather this parameter is set or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: KeyvaultEncryption
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeyVaultResourceID
DataBox job encryption keySource keyvault resource id

```yaml
Type: System.String
Parameter Sets: KeyvaultEncryption
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
Name of the databox job to be updated.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Resource Group Name under which the databox job has to be updated.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.PSDataBoxJob

## NOTES

## RELATED LINKS
