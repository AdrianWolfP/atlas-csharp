#!/bin/bash

# Create a folder 
mkdir 2-new_project
cd 2-new_project

# Initialize a new C# console application
dotnet new console

# Build the project
dotnet build

# Run the project
dotnet run