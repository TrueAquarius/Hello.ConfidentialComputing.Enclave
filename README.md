# ConfidentialWordCount

"Hello World"-Beispiel für Confidential Computing mit Azure DCsv2, .NET 8, C# (REST API), C++ (Enklave), Open Enclave SDK.

## Architektur

Client ⇄ REST API (.NET 8) ⇄ Enklave (C++/Open Enclave) ⇄ Word Count

## Projekte

- **ConfidentialWordCount.Api**: REST API (C#)
- **ConfidentialWordCount.Enclave**: Enklavenlogik (C++)
- **ConfidentialWordCount.Enclave.Common**: Gemeinsame Header/Interfaces

## Deployment

- Siehe Ordner `Deployment` für Skripte und GitHub Actions.

## Lizenz

Siehe [LICENSE](LICENSE).
