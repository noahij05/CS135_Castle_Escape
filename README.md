Fellow Programmers
---------------------------------------------
[Jacob Halvorson](https://github.com/jhalvorson6687)  
[Christopher Diaz](https://github.com/ChristopherDiaz98)  




Introduction
-----------------------------------------------
<p align="center">
  <img src="https://github.com/noahij05/CS135_Castle_Escape/blob/main/Photos/intro_photo.PNG?raw=true">
</p>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For our final project we built a medieval castle obstacle course where the player must
evade dangerous enchanted weapons and pools of lava to reach the finish line as fast as they
can. This is a solo player game where the goal is to try and beat your high score. The keep is
located in an eerie secluded forest surrounded by mountains and thick fog. There are various
time counters placed after obstacles in the virtual world to display how long the player has been
going. We also added secret methods to do the course faster for competitive players that do
speed runs. The front gate is two swinging axes that knock you back if they hit you. However if
you position correctly you can ride the axe to the top floor. We left it like this so players could
find neat tricks to improve their performance even marginally. While we unfortunately did not
access a VR set this quarter, having a virtual reality experience would make this more
immersive than a keyboard and mouse. Giant medieval weaponry swinging in your face and
falling into lava in first person would increase the users sense of actually being in that situation,
making for a more immersive experience.

Related Works
-----------------------------------------------
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; When we first started to develop ideas for our game we took a look at the recently
popular game Fall Guys. We took a look at what type of objects were used and the type of
obstacle courses they used. We ended up using a lot more muted colors such as the greys of
the castle and dark greens of the forest. Compared to Fall guys our game is much easier on the
eyes as to not strain them and to give the user a more friendly experience. Another difference is
that ours is entirely first person compared to the third person perspective of Fall Guys. This
makes the threat of the obstacles larger as the feeling of danger is there for you rather than a
controlled character. Fall Guys also runs on having a multiplayer experience which means that
they have to eliminate people based on time. With our timer continuously Another game that we
took inspiration from is Dark Souls. There is an important area within the game that has many
similarities when it comes to the aesthetics of the architecture. There are also similar designs
when it comes to the obstacles, however, many of them include violent deaths which would be
quite jarring to the player of our game. This is why we ended up making the obstacles reset your
starting point rather than lose outright.  

Design
--------------------------------------
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The main components of our project consisted of the Terrain, Castle, Obstacles, and
different menus and displays throughout the game. Below are screenshots of the main sections of the game:  
<p align="center">
  <img src="https://github.com/noahij05/CS135_Castle_Escape/blob/main/Photos/terrain.PNG?raw=true">
</p>  

<p align="center">
  <img src="https://github.com/noahij05/CS135_Castle_Escape/blob/main/Photos/Castle_obstacles.PNG?raw=true">
</p>  

Menu
---------------------------------------
<p align="center">
  <img src="https://github.com/noahij05/CS135_Castle_Escape/blob/main/Photos/menu.PNG?raw=true">
</p>  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; We wanted to design the game so that if it were VR the player would really feel like they were in
a dangerous medieval setting, so rather than just building the obstacle course, we also built a
surrounding terrain that resembles a common type of area where castles were built, a place with
natural defense mechanisms. We designed a surrounding with mountains, hills, trees, and thick
fog to give that medieval feeling. Again with VR in mind, we designed the menus and displays
such that they are not attached to the user's screen. Instead, these components are a part of
the virtual world that the user can turn their head to see. The provides a better VR experience
for the user. We chose to use keyboard and mouse because we unfortunately had no other
option, however we designed the game to be as VR friendly as we could. On the other hand, we
did not realize sooner how jarring the jumping mechanics may be to some users. So to some
this game would be a great VR experience, however to others it could easily cause motion
sickness. The controls for our game were pretty basic as the main mechanic was avoiding
obstacles, so we only needed w, a, s, and d to move and the spacebar to jump. Additionally, we
made 1 start the timer so the user can explore the map or practice the course without the timer
running.  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; While we did not have access to VR hardware, we did try to take it into account. For
instance our color scheme consists of nice, muted colors. This means that the player will feel
less eye strain when playing the game for longer periods of time. When inside darker places, we
illuminated them slightly more than average so that the player can have an easier time seeing
their way around the course.

Implementation
--------------------------------------
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; For our implementation we used the C# coding language to make our obstacles have
specific interactions with the player. We also used this language to set up a way to show and
record the time it would take to complete the course. The three scripts that we used to set up
the game were teleport.cs, timer.cs, and the orbit.cs scripts. The most important script that we
used was the teleport.cs script as it was the primary code of how we would set up the obstacles.
This, as the name suggests, would send the player back to specific locations based on the
section of the course they were at. The next script that was used to implement the game was
the timer.cs script. We needed it to do two primary things, keep track of the time passed after
the start button was pressed and to display the previous scores after the game is exited. The
last script used was the orbit.cs script which was used to make the objects such as the axes
and the swords rotate so that they would be a more dangerous obstacle to get around.  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A major problem we encountered was with the obstacles knocking the player back. We
initially thought we could just have an obstacle knock a player back as an inconvenience for not
avoiding it. Unfortunately, we ran into a problem with forces working on a kinematic rigidbody.
We learned that you cannot add force to a kinematic rigidbody. If we disabled the isKinematic
variable, the player fell through the floor. This is when we decided to switch our focus to a
different punishment. So to solve the consequence issue, we teleported the player back to a
specified checkpoint. We also encountered a similar issue with our boulder obstacle. We could
not make the boulders kinematic and be affected by gravity. At first, our boulders just fell right
through the floor! So we came up with the idea of having 2 sphere colliders, one surrounding the
boulder exactly with a proper physics material, and another one that extended beyond the
boulder by just a bit and acted as a hit box to detect when the player hit it.

Assets Used
--------------------------------------------------
[Standard Assets](https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351)  
[Brick Walls](https://assetstore.unity.com/packages/2d/textures-materials/brick/tileable-bricks-wall-24530)  
[Lava Textures](https://assetstore.unity.com/packages/2d/textures-materials/nature/stylized-lava-texture-153161)  
[Melee Weapons Pack](https://assetstore.unity.com/packages/3d/props/weapons/melee-weapons-pack-swords-axes-121237)  
[Used to learn timers](https://www.youtube.com/watch?v=x-C95TuQtf0&feature=emb_title)  
[Orbit.cs given in the first lab](https://github.com/noahij05/CS135_Castle_Escape/blob/main/Assets/Orbit.cs)

Lessons Learned
-------------------------------------------------
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; We all learned a lot about unity and VR/Game Design throughout this project. I (Jacob)
have wanted to learn how to create video game environments and terrain and was able to
accomplish that with this project. I (Chris) have learned how to take into account how games,
first person or otherwise, need to take a lot of consideration of how the user will interact with the
game. For one example we originally made the axes as a small deterrent so that the player can
be knocked back a little but after playing the game myself I have found that the player can use it
as a way to cheat the course. I (Noah) learned how to implement different forces and physics
into the game as well as work arounds for when those mechanics were not entirely possible. For
instance, I was the one that found the work arounds for the boulders refusing to fall and/or just
falling through the floor. We split the workload in a way all of us could be working on the project
at the same time. At the start when we were deciding on the basic game design and map layout
we had one person on Unity coding/designing while the other two watched and helped on
screen share, like a pair programming technique. Once the basic design was implemented we
uploaded the project to Unity Dashboard and Jacob continued developing the map and castle
while Chris and Noah worked on the game scripts and mechanics. When a mechanic/obstacle
was finished the game objects were made into prefabs and sent with the scripts to Jacob to put
in the most current version of the game.  

How to Use This Repository and/or Play The Game
-------------------------------------------------
The directory to access if you want to change/add assets will be: 
```
Assets/
```
  
If you wish to just run the game and see our amazing creation, then follow these steps:  
From command line:
```
unzip cs135_final_project_exe.zip
cd cs135_final_project_exe/
./cs135_final_project
```  
From a file explorer, just unzip the *cs135_final_project_exe.zip* folder and run the *cs135_final_project.exe* file!
