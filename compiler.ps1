# check README.txt for info
$conf = Get-Content -Path .config | ConvertFrom-Json
$r = -join ((65..90) + (97..122) | Get-Random -Count 8 | % {[char]$_})
$c = ([regex]$conf.namespace).replace((Get-Content $conf.source), $r, 1) | Out-String
Add-Type -TypeDefinition $c -Language CSharp
iex "[$r.$($conf.class)]::Main($($conf.args))"