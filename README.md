# Pool Rooms Dungeon for Lethal Company
A Work-in-progress mod for Lethal Company featuring a interior layout all about the classic swimming pool asthetic.

Thunderstore Link: https://thunderstore.io/c/lethal-company/p/skidz/PoolRooms/

## Features / Supports
- 13+ Different room variations
- 3 custom scrap items (more coming!)
- Breaker box, Apparatus room, Steam Valves
- Lighting controlled by the breaker box and apparatus
- Big Locking Doors controllable via the ship computer
- Monster vent spawners
- Turrets and Landmines
- Doors and keys
- Usable pool ladders!
- Functioning lockers with loot inside
- Water splashes particles and sounds from players as they move through water areas

## TODO
- General overall tuning
- More clutter and room details
- Allow player to drown and make water a hindrance to speed
- Pool Noodle weapon

## FUTURE
- More Rooms?
- More Custom Scrap

## Screenshots
![Alt text](https://github.com/rfsheffer/PoolRooms/blob/main/Screenshots/shot1.jpg?raw=true "Shot 1")
![Alt text](https://github.com/rfsheffer/PoolRooms/blob/main/Screenshots/shot2.jpg?raw=true "Shot 2")
![Alt text](https://github.com/rfsheffer/PoolRooms/blob/main/Screenshots/shot3.jpg?raw=true "Shot 3")
![Alt text](https://github.com/rfsheffer/PoolRooms/blob/main/Screenshots/shot4.jpg?raw=true "Shot 4")
![Alt text](https://github.com/rfsheffer/PoolRooms/blob/main/Screenshots/shot5.jpg?raw=true "Shot 5")
![Alt text](https://github.com/rfsheffer/PoolRooms/blob/main/Screenshots/shot6.jpg?raw=true "Shot 6")

# How to build and install
- Install Evaisa Netcode patcher using the command: dotnet tool install -g Evaisa.NetcodePatcher.Cli
- Pull this repo to a folder to work in
- Grab the DunGen plugin from here: https://assetstore.unity.com/packages/tools/utilities/dungen-15682
- Place the DunGen folder into the projects Assets folder, do not replace anything as the .meta files need to be maintained as they are
- Open the Unity project in unity 2022.3.9f1
- Run from the drop down "Lethal Dungeon/Build Dungeon Bundle". This will generate the bundle into Assets\DungeonBundles
- Grab the bundle "poolrooms" for later
- In your lethal company folder where BepinEx is create a folder called "PoolRooms" in BepInEx\plugins
- Copy "Plugin\Prebuilt\PoolRooms.dll" into the "PoolRooms"
- Copy "exampledungeon" into the "PoolRooms"
- Make sure to have LethalLib and HookGenPatcher installed into your BepInEx plugins
- Run the game and close. You can now modify "BepInEx\config\PoolRooms.cfg" to assign the dungeon to the moons you would like using the "Moons" setting

# Checking how the dungeon will look before opening Lethal Company
In Unity open the GeneratePoolRooms scene and run it.

# Dependencies
- Evaisa Netcode patcher
- You will need a copy of the plugin DunGen to use this project. The files must be placed in Assets/DunGen. Do not replace the .meta files already in there.
- LethalLib : https://github.com/EvaisaDev/LethalLib
- LethalLevelLoader : https://github.com/IAmBatby/LethalLevelLoader

# Attributions and licenses
The plugin was initially based on Badhamknibbs SCP dungeon code which can be found here:
 https://github.com/Badhamknibbs/SCPCB_DunGen_LC

Water Shader:
 https://github.com/flamacore/UnityHDRPSimpleWater

First Time Audio:
soundscape: Underwater Eerie Ocean Ambience
 https://www.youtube.com/watch?v=xr2ARQFnF8k

The code of this mod is provided under the MIT license (see license file)
