# Introduction
- Bolt Game Jam Template is a pre-made starter kit Unity Visual Script template for a game.
- Included a Title screen and a Main screen with a menu panel, options panel and pause panel using Unity's GUI system.

# Features
## 1. Main Menu
- Placeholder title image and title text
- Start Button
- Options Button
- Quit Button
- Fade to black (or any color assigned to FadeImage) when transitioning out of main menu to main scene

## 2. Options Panel
- Music Volume
- Sound Effects Volume
- Back Button

## 3. Pause Panel
- Music Volume
- Sound Effects Volume
- Resume Button
- Quit Button

## 4. Music
- Play music based on scene number
- Music pre-routed to Audio Mixer, connected to UI


# How to use   

1. Import this asset into your project
2. Open Build Setting: In Unity Editor click File > Build Settings
3. Add TitleScene and MainScene in Scenes folder into Build Settings
4. Open TitleScene in Scenes/TitleScene and press the Play button to start

# How to use your own music
- There are two music files: title_scene is the background music in the TitleScene and main_scene is the background music in the MainScene
- Replace the music files at Assets/Bolt Game Jam Template/Audio/Music
- Re-drag the new music files into Audio Source component of BGMusic gameobject in TitleScene and MainScene
