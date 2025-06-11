# Deployment-Skript für ConfidentialWordCount auf Azure DCsv2 VM

# 1. Build Solution
dotnet build ../ConfidentialWordCount.sln -c Release

# 2. (Optional) Weitere Schritte wie Enklaven-Signierung, Bereitstellung, etc.
Write-Host "Deployment abgeschlossen."
