# ConfidentialWordCount.Api

Dies ist die REST API für das Confidential Computing "Hello World"-Beispiel. Sie nimmt Textdaten entgegen, leitet sie an die Enklave weiter und gibt die Wortanzahl zurück.

## Endpunkt

- **POST /wordcount**  
  Body: Text  
  Response: `{ "wordCount": <int> }`

## Lizenz

Siehe [LICENSE](LICENSE).
