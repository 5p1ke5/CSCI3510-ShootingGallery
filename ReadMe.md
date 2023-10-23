Changes to this project are made in two halves.

How To Push Changes:

0. Make sure your changes work and don't break the build.
1. Create a package containing all changed assets -NOT- in 'Repo' or 'Imports'. Give this package a descriptive name. The reccommended format is "DescriptiveTitle_DATE_MILITARYTIME" (eg its 10/22/2023 and 7 PM here so I might make a package titled "DoubleJump_10222023_1900". 
2. Upload this package to the drive.
3. Open a terminal window in the 'Repo' directory and run `git commit -m "(MESSAGE)" Message should list what changes were made as well as what package goes with it. (eg `git commit -m "Added a doublejump feature, uses package DoubleJump_10222023_1700"`)
4. `git push`

How to Pull Changes:

1. Check the github and see what changes require packages.
2. Get the packages referred to in the commit messages off of the drive and import them.
3. `git pull` to update Scenes, Prefabs, and Scripts.
4. Run `git merge` if prompted.

Creating a new Build:
This is for having a coherent baseline. New builds will be created periodically.
1. Make sure the project is up to date and works with all changes.
2. Zip the entire unity file structure.
3. Title this "ProjectName_DATE_MILITARYTIME"
4. Upload to the Builds folder in the google drive.
