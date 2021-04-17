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

Then to execute the service run the following command:
`dapr run --app-id lampservice --components-path ../dapr/components python3 lampservice.py`