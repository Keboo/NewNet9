# Dotnet global tools roll forward option
https://learn.microsoft.com/dotnet/core/whats-new/dotnet-9/sdk?WT.mc_id=DT-MVP-5003472#net-tool-roll-forward

`dotnet tool install` now supports a `--allow-roll-forward` option which sets the roll forward mode to `Major`. This allows a tool to run on a newer **major** version of .NET without the tool author needing to update.