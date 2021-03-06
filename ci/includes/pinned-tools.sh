#!/usr/bin/env bash
error() {
   local SOURCE_FILE=$1
   local LINE_NO=$2
   echo "ERROR: ${SOURCE_FILE}(${LINE_NO}):"
}

function isLinux() {
  [[ "$(uname -s)" == "Linux" ]];
}

function isMacOS() {
  [[ "$(uname -s)" == "Darwin" ]];
}

function isWindows() {
  ! ( isLinux || isMacOS );
}

function cleanUnity() {
  rm -rf "$(pwd)/workers/unity/Library/"  
  rm -rf "$(pwd)/workers/unity/Temp/"
}


# Ensure for the Mac TC agents that dotnet is on the path.
if isMacOS; then
  if ! which dotnet; then
    export PATH="${PATH}:/usr/local/share/dotnet/"
  fi
fi

# Print the .NETCore version to aid debugging,
# as well as ensuring that later calls to the tool don't print the welcome message on first run.
dotnet --version

export LINTER="cleanupcode.exe"

DOTNET_VERSION="$(dotnet --version)"

if isWindows; then
  export MSBuildSDKsPath="${PROGRAMFILES}/dotnet/sdk/${DOTNET_VERSION}/Sdks"
fi