Apple Picker 3D – Unity Game
Project Overview

Apple Picker 3D is a Unity-based game inspired by the classic Apple Picker tutorial from Bond (Ch. 29). Players control a basket to catch falling apples while avoiding hazardous objects (bombs/cinder blocks). The game includes multiple rounds, scoring, and a simple UI for round tracking and game restart.

This project was developed as part of CS382 – Game Design, Development, and Technology (Project 1).

Key Features

4 Baskets for catching apples

Round system with UI display (“Round 1” → “Round 4”)

Apples that increase score when caught

Bombs / cinder blocks that end the game if caught

Start and Restart UI buttons

Simple 3D environment with physics-based falling objects

Gameplay Instructions

Launch the game in Unity or build as a standalone application.

Move the basket horizontally with the mouse to catch apples.

Catch apples to gain points (+100 per apple).

Avoid bombs: catching a bomb ends the game immediately.

The game progresses through 4 rounds. If all baskets are lost or a bomb is caught, the game ends.

Press the Restart button to play again.

Installation / Running the Project

Clone the repository:

git clone <your-repo-link>


Open the project in Unity Hub (recommended Unity version: 2021.3 or later).

Open the Main Scene.

Ensure all prefabs are assigned in the Inspector:

AppleTree → applePrefab

AppleTree → bombPrefab

ApplePicker → basketPrefab

Press Play in the Unity Editor to test the game.

Project Structure

Assets/Scripts/ – C# scripts for game logic:

ApplePicker.cs – manages baskets, rounds, and game restart

Basket.cs – basket movement, apple scoring, bomb detection

AppleTree.cs – moves the tree and drops apples/bombs

Apple.cs – apple falling and missed detection

Bomb.cs – bomb falling logic

RoundCounter.cs – UI text for rounds and Game Over

Assets/Prefabs/ – reusable prefabs:

Basket

Apple

Bomb

Assets/Scenes/ – main Unity scene

Controls

Mouse X: Move basket horizontally

Start Button: Begin the game

Restart Button: Restart after game over

Credits

Original Apple Picker tutorial: Bond, Chapter 29

CS382 – Game Design, Development, and Technology, Spring 2026

Developed by: <Your Name> (and <Partner Name> if applicable)
