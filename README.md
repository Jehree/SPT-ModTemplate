1. Use something like GitBash to clone the repo into a folder on your computer (https://git-scm.com/downloads) or download it manually with **Code > Download ZIP**
2. Delete the **.git** folder
3. Rename the following from _ModTemplate_ to your new mod name:
    * Folder the project is in
    * **.csproj** file
    * **.sln** file
4. Open the **.sln** file with a text editor, CTRL+F for _ModTemplate_ and replace it with your new mod name
5. Open the **.csproj** file with a text editor, CTRL+F for _ModTemplate_ and replace it with your new mod name (do this in all project folders)
6. Open your solution by double clicking your **.sln** file, double click **Plugin.cs**
7. Press CTRL + Shift + F, click Replace in Files
    * make sure **Look in** is set to **Entire solution**
    * in Find field, enter: _ModTemplate_
    * in Replace field, enter your new mod name
    * click Replace All in bottom right, click yes if prompted
