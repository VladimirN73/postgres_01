[CmdletBinding()]
param (
    [Parameter()]
    [bool]$Pull = $true,

    [Parameter()]
    [bool]$Up = $true
)

Get-Content .\.env 

if ($Pull) {
    docker compose -f .\docker-compose.yml pull
}

if ($Up) {
    docker compose -f .\docker-compose.yml up -d --remove-orphans
}
