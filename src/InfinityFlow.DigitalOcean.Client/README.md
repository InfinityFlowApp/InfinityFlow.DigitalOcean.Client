# DigitalOcean Client

Regenerate the client with the following command:

```bash
docker image rm -f mcr.microsoft.com/openapi/kiota:latest

docker pull mcr.microsoft.com/openapi/kiota:latest

# To Create 
docker run -v ${PWD}:/app/output mcr.microsoft.com/openapi/kiota:latest generate --language csharp --class-name DigitalOceanClient --namespace-name InfinityFlow.DigitalOcean.Client -d https://api-engineering.nyc3.cdn.digitaloceanspaces.com/spec-ci/DigitalOcean-public.v2.yaml

# To Update, uses the `kiota-lock.json`.

docker run -v ${PWD}:/app/output mcr.microsoft.com/openapi/kiota:latest update
```

