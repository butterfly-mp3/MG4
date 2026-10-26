# MG4
## Devlog
*Explain how the FloatAnimation script works to animate the fish food GameObjects up and down. Make sure to mention the Start() and Update() methods and _up and _timer variables. You can ignore the StopAnimation() method.*
    At the beginning, it sets the timer to the switchSpeed variable, which dictates the amount of time it takes to switch from moving up to moving down. In the update, it reduces that time by delta and then checks every frame if the nhumber fell below 0. If it did, it resets the timer to switchSpeed, and changes the direction of movement using the variable _up, which is true or false based on if the bubble is supposed to be moving up or not.

## Open-Source Assets
- [Quirky animal 3D models](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235)
- [City 3D models](https://assetstore.unity.com/packages/3d/environments/simplepoly-city-low-poly-assets-58899)
- [Bite sound effect](https://freesound.org/people/Jofae/sounds/353067/)