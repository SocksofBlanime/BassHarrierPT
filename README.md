# BassHarrierPT

Bass Harrier is put together by having scrolling backgrounds coded to the main viewing camera as well as programmed moving parts of the board
The Floor board moves and lights up to the beat of the song playing on the stage
The player character is on a moving chain on the Z-axis with the element of 2D play. Up,left, right, and down(when applicable) are your directions of movement. Set the camera as a child of the player character to make things easier. Set the X location to 0, Y Location 5,and  Z location to -10
Spacebar is to shoot the enemies 
This is a nonprofit project and is not to be sold or resold due to liscensing
The prefabs folder has all of the different type of level flooring and character models needed ingame.
For Each level you must add an Empty object named BPEERM then apply the BPEER M code. This will allow the floor segment to move to the BPM set for the level
You must create an Audio Source named BGM and add the music. (NOTE: the BPM must be accurate to the song otherwise you're off beat!)
Gamemanager has variable for scoring and are written out in the editor
The kremlings script is an enemy spawner script. When creating the spawner you need to create an empty game object followed by 4 child empties that will be your spawn points. Keep the range withing -19 to 19 on the x-axis and 0 to 10 on the Y-axis
The only current win conditions set right now are when the song is over.
For some reason every level needs one version of the obstacle or enemy in the hieracrchy in order for the code to take effect. There is an obstacle called jungle root that will only attack the player if there is one active in the hierarchy.


Songs & BPM;

Bird-110BPM
Cold Lava- 120BPM
JustLiving- 83BPM
Final Chase- 74BPM
TheArk- 140BPM
FlowersGrow- 180BPM
Reanimation- 70BPM
Kampong Boogie- 97BPM
Karma-132BPM
Up- 107BPM
PlanetFitness-80BPM
Unconscious- 82BPM
Death Ruins- 131BPM
Falling Upwards-120BPM
Wowzer-70BPM
