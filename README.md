# dockerized-dotnet-scripting
Allows for running and debugging dotnet script files via a docker container. Leverages VS Code's [Remote Containers](https://github.com/microsoft/vscode-dev-containers) to easily create and run the scripts via an included task.

## Requirements
* VS Code
* [Remote Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) extension
* Docker


## How To Run
1. Open up the project in VS Code
2. Use the `Remote Containers - Rebuild and Reopen In Container` command to intall and run the container.
3. Create a csharp `csx` script file in the solution.
4. When the desired file is open, run the included `.Net Script Debug` task to run the script against the remote container.
5. To debug, simply set a breakpoint in the file and it will be hit when run.