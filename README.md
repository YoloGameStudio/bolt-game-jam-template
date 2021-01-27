# Introduction
- Bolt Game Jam Template is a pre-made starter kit Visual Script template for a game.
- Included a Title screen and a Main screen with a menu panel, options panel and pause panel using Unity's GUI system.

# Features
## Main Menu
- Placeholder title image and title text
- Start Button
- Options Button
- Quit Button
- Fade to black (or any color assigned to FadeImage) when transitioning out of main menu to main scene

## Options Panel
-Music Volume
-Sound Effects Volume
-Back Button

## Pause Panel
-Music Volume
-Sound Effects Volume
- Resume Button
- Quit Button

## Music
-Play music based on scene number
-Music pre-routed to Audio Mixer, connected to UI
        
# How to change the music
- Replace the music files at Assets/Bolt Game Jam Template/Audio/Music
- Re-drag the new music files into Audio Source component of BGMusic gameobject in scene
