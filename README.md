# daprlamp
DAPR Hackathon project to change the status of a lamp based on a build status

## BuildService
ASP.NET Core Web API with a webhook to receive a build status and publish an event to the corresponding topic
To run execute the following command in the BuildService folder:
`dapr run --app-id buildservice --components-path ../dapr/components dotnet run`

## LampService
Python Web API with an endpoint to change the status of a lamp
Subscribes to the corresponding topic of a build
To run you first need to install it's dependencies
Run the following command in the LampService folder:
`pip3 install -r requirements.txt`

Install enable redis in docker
`docker run --name redis -d -p 127.0.0.1:6379:6379 --restart unless-stopped arm32v7/redis --appendonly yes --maxmemory 512mb --tcp-backlog 128`

Configure the service bus in the dapr\components\pubsub.yaml

Then to execute the service run the following command:
`dapr run --app-id lampservice --components-path ../dapr/components python3 lampservice.py`