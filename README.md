# UnityUtils
A collection of scripts I use in my unity projects

## Current Utilitys

### 2D Dynamic Sorting Order
Changes the Sorting Order of Gameobjects during runtime to make things further up render behind and things further down render in front.

### 2D Static Sorting Order
Like the Dynamic Sorting order, except will only run once, Meaning it should only be used for objects which do not move within your scene

### Basic 2D Camera
A very basic 2D camera, has two bounds, x and y, and when passed the camera will follow the targeted gameObject.

### Collidable
A class to be inherited from, gives the ability to run a function on collision, with an unlimited number of collisions overlapping.

### Face Mouse 2D
Makes the GameObject it's attached to always follow the mouse.

### Screen Shake
Contains a function to trigger a screen shake effect, Duration and Strength of the shake can both be set through this function.

### Lerp To Point
Moves a GameObject to a given point, the amount of time taken to move there will not change depending on distance but speed will

### Fixed Speed Lerp To Point
Moves a GameObject to a given point, the speedt will not change depending on distance but the amount of time taken will