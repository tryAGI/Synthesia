# Authentication

The Synthesia SDK uses API key authentication via Bearer token in the `Authorization` header.

You can obtain an API key from your [Synthesia account settings](https://app.synthesia.io/).

## Basic Usage

```csharp
using Synthesia;

var client = new SynthesiaClient(apiKey: Environment.GetEnvironmentVariable("SYNTHESIA_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `SYNTHESIA_API_KEY` | Your Synthesia API key |
