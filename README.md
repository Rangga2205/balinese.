![image](https://github.com/user-attachments/assets/63209c63-2028-49f5-9589-94adae21b514)

## 🔴 About
**Balinese** is a **Visual Novel** game made with a story concept in Bali. Players can play and choose the plot in the story to build the story that has been created. In this game, taking the story theme of the old days in Bali. Diverse level designs and Backsound music that deepens the plot of the story. Each story has a uniqueness that makes it more interesting. Has more interesting sound and visual effects. 

This game is set in Bali Beach with System and Pause features. For example, if players want to pause, they can use the pause button so they don't miss the story

## ▶️ Video Gameplay
<img src="https://github.com/user-attachments/assets/f88d9b82-f38a-48f8-bbac-da68856dfc09" width="350" height="200">

View Full Gameplay : https://youtu.be/0ZJpfFQ3HeM?si=rkbvegm7qnJEFB-c

## 🕹️Play Game
itch.io : Wating Update

## 📋 Project Info
- Made using Unity Editor 2022.3.19f1.
- [**Golem Chibi Spirte**](https://craftpix.net/freebies/free-golems-chibi-2d-game-sprites/).
- [**Heart**](https://drive.google.com/drive/folders/1audm9sjm-JiGRu4PtckMoI8a_nudnzHg?usp=sharing).
- [**Check Point Sound**](https://mega.nz/file/KxNSRS6L#Sw4eB5LEKRVbNyfz0aleRH3B-Te36AHKm7RVOLID-xc).
  
| Part | Development Time |
|------------------|------|
| Map Set | 60 Minutes|
| Player and Enemy | 120 Minutes |
| trap and CheckPoint | 80 Minutes |
| Mecanic | 600 Minutes |
| Level Design | 90 Minutes |
| UI Menu | 60 Minutes |

## 📜Scripts and Features
- UI Pause Menu players can exit the game or reload from this menu.
- Has Checkpoint to save player position.
- Sound Effect.

| Script                | Description                                                                 |
|-----------------------|-----------------------------------------------------------------------------|
| `gameManager.cs` | Script manages the game state by ensuring there is only one active instance, handling scene changes, and controlling. |
| `UIGameplay.cs` | Manages the user interface by managing the pause, resume, and menu buttons, and connecting button. |
| `TriggerEvent.cs` | Detects collisions with objects that have a specific tag and triggers. |
| `PlayerPositionHandler.cs` | Checkpoint when the player interacts with an object, and repositioning the player back to the checkpoint.|
| `etc` |                        

## 📂Files description

```
├── GodRock                    # In this Folder, containing all the Unity project files, to be opened by a Editor
   ├── Assets                         #  In this Folder, it contains all our Script, audio, scenes, animation, prefabs, Cave, Sprite
    ├──Cave                 # In this folder, there packages Map 
      ├── Scenes                     # In this folder, there are scenes. You can open these scenes to play the game via Unity
      ├── ....
   ├── ...
      
```

## 🕹️Game controls
| Script | Description |
|----------------------|------------------|
| left and Right arrow | Movement|
| Space | Jump |
| left Clik | Attack |
| esc | Pause Menu |

## 🔥How to open up the project on Unity Editor
This game was developed using **Unity Editor 2022.3.19f1.**, and we recommend that you download this specific version because using different ones, especially older versions, might result in problems.

<img src="https://github.com/user-attachments/assets/b28116d6-7128-458e-a041-ee5f336c5a55" width="350" height="200">

You are required to download some assets from the Unity Asset Store to operate this game properly. The assets that need to be downloaded are as follows:

**Download Here:** 
- Logitech SDK : https://unity.com/releases/editor/whats-new/2022.3.19
  
