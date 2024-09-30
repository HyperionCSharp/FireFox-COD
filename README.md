# FireFox Game API Tool

## Overview
FireFox is a tool that interfaces with the **BlackOps Cold War** game through the **FireFox API**. It allows users to interact with various in-game functionalities, such as modifying player stats, enabling rapid fire, teleporting players, spawning weapons, and more. The project leverages several background workers and external libraries to provide these functionalities in real-time while the game is running.

## Features

- **Player Stats Management**
  - Modify player stats including kills, critical kills, elite kills, and rounds played.
  - Set customizable stats values for multiple players.
  - Randomize player stats between low, medium, and high ranges.
  
- **Weapon Handling**
  - Spawn weapons and reticles for players.
  - Manage weapon cycles and reticle unlocks.
  
- **Rapid Fire**
  - Enable or disable rapid fire for all clients.
  
- **Teleportation**
  - Teleport players or zombies to specific coordinates in the game world.
  
- **Unlimited Ammo**
  - Toggle unlimited ammo for all players.
  
- **Instant Kill**
  - Enable instant kill for zombies.

- **Discord Integration**
  - Sends automated messages to Discord using webhooks when certain actions are performed (e.g., starting a reticle lobby).

## Setup

1. Clone the repository:
    ```bash
    git clone [https://github.com/HyperionCSharp/FireFox-COD.git]
    ```

2. Install necessary dependencies. This project uses several libraries like `FireFoxAPI1One`, `FireFoxAPITwo`, and `FireFoxAPIThree`. Ensure these are correctly referenced in your solution.

3. Run the project from your IDE (such as Visual Studio).

4. Ensure that **BlackOps Cold War** is running. The tool will connect to the process named `BlackOpsColdWar`.

## Usage

### Connecting to the Game
- The tool automatically connects to the game process once it detects `BlackOpsColdWar` running.

### Player Stats Modification
- Select the player and modify their stats by inputting values or using the randomize functions. You can set the number of kills, rounds played, elite kills, and more.

### Weapon Spawning
- Use the reticle spawning feature to cycle through a set of weapons. The tool also tracks player kill counts and adjusts the weapons accordingly.

### Discord Notifications
- When starting certain actions (e.g., reticle lobbies), notifications will automatically be sent to the specified Discord webhook.

### Teleportation and Zombie Control
- Teleport players or freeze zombies at will using the built-in teleport options.

## Contributing

If you'd like to contribute, feel free to create a pull request or submit issues on GitHub. For major changes, please open an issue first to discuss what you would like to change.

## Other
Is compatible with ArtemisAI for AI based protections alongside the default protections.
