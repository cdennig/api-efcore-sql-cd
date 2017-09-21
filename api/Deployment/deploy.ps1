break
Login-AzureRmAccount

$rg = "sampledbcd-rg"
New-AzureRmResourceGroup -Name $rg -Location westeurope
New-AzureRmResourceGroupDeployment -ResourceGroupName $rg -Mode Complete -TemplateFile ".\deployment.json" -TemplateParameterFile ".\parameters.json"