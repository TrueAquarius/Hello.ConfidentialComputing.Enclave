# Deployment

Hier befinden sich Skripte und Hinweise zur Bereitstellung auf Azure DCsv2 VMs.

## Schritte

1. Solution bauen:  
   `dotnet build ..\ConfidentialWordCount.sln -c Release`

2. Enklave signieren und bereitstellen (siehe Open Enclave SDK Doku).

3. REST API starten.

## Lizenz

Siehe [LICENSE](../LICENSE).
