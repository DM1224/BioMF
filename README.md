# BioMF
A prototype web-based program using Blazor to find network motifs. Currently supports a motif-centric algorithm with ParaMODA as its algorithm implementation.

# Requirements
* Visual Studio 2019
* Blazor plugin for Visual Studio
* Read [Get Started With Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/get-started?view=aspnetcore-3.1&tabs=visual-studio)

# How To Run
1. Make sure to have the latest Visual Studio downloaded on your computer. This will also work for Mac users
2. Download the zip file of the BioMF source code and extract to a desired folder
3. Double click on the BioMF solution file when you download the source files
4. Run the BioMF debugger
5. A static website on local host for BioMF will pop up, and you are given 3 options. Be sure to only have "None" selected
6. Select the size of the subgraph by using the slider, do note that size 4 or size 5 will take a while to process and 
it seems like the page is frozen
7. Choose a network text file before pressing start
8. Select start and wait until it has finished processing
9. Once the processing is finished, you are redirected to the results page
