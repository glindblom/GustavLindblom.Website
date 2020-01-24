$ErrorActionPreference = "Stop"
$output = "$PSScriptRoot\out";

if ((Test-Path $output) -eq $true) {
	Remove-Item $output -Force -Recurse
}

New-Item $output -Type Directory

& dotnet publish --output $output --configuration Release