[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

Objects
 –UI
   -seeds planted UI
Start with 0, increase as pressing space
Attribute: text
   -seeds remaining UI
Initially 5, decrease as pressing space
 
 --player 
Movement (WASD)
Plant (space)
   Decrease seed count and increase plant account
-Iinput- WASD keys
-Output - if the player has seeds remaining: 1 seed is planted at the player’s location; decrease seed count + increase plant count (show up UI)
Attributes: sprite, xy coordinates
Check the number of seeds before planting(the player has to have a seed before planting, create a plant object at its current position

–plants
Appear
Attribute: xy coordinates, sprite
Action  none, static
Check seeds, create a plant, update seed count, update plated seeds count, Ui update

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!


---In this in-class activity, I devide my plan to 3 crucial part: UI of the seeds remain, UI of the seeds planted, and the basic actions of the player. According to my plan, player's movement is controlled by WASD, which is the same as what prof listed on Canvas. I mainly used float to move and check space to plant seeds. Later I realized some incompletion in my code caused my player unable to move, so I add transform.Translate to enable the player to move. When I try to realize the rest of the game with code, I use the Player genre to deal with the input of player and management of seeds. Player part includes Start(), Update(), and PlantSeed(),which were skeletons that given.I later specified and elaborated them with detailed steps I listed in HW1  breakdown.

--For the UI part, under the PantCountUI, I first use UpdateSeeds (int seedsLeft,int seedsPlanted)to show the remain and planted seeds as what I planned in the plant's output section. I use if statement in my code to check whether the number of seeds is greater than 0. If the answer is true, than the player can continue planting, so I use Debug.log to output. This step to check the remaining seeds is exactly what I planned in my HW1 breakdown. What I didn't wrote in HW1 breakdown but actually added when I coded was to write what will happen if the number of seeds remain is equall and smaller than 0. I wrote output that "no seeds left to plant!" in my code to avoid issues happen.

-- The detailed plan helped me have a clear logic  when I wrote codes. However it doesn't include what I should change in Unity. One problem I faced is that I have double UI in the scene and I don't know how to fix it, until I found that  _plantedText.text includes names of UI that has already existed under the canvas part, so I deleted the name in PlantCount UI. This reminds me to double check what's already existed in Unity before coding.
## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
