# 🔫 **FPS Multiplayer Shooter** 🚀

**Dive into the action!** Experience intense multiplayer battles in this fast-paced 3D first-person shooter built in Unity. With smooth gameplay, real-time networking, and customizable weaponry, this game delivers a thrilling multiplayer experience for players worldwide.

---

## **🌟 Features**
- **Real-Time Multiplayer**: Play with friends or challenge players across the globe with seamless networking using Photon PUN or Unity Netcode.
- **Dynamic Weapon System**: Choose from an array of weapons like pistols, rifles, and shotguns, each with unique mechanics.
- **Customizable Loadouts**: Tailor your gameplay by selecting your weapons and gear before jumping into battle.
- **Interactive Maps**: Engage in combat across multiple arenas with interactive elements and diverse layouts.
- **Realistic First-Person Mechanics**: Smooth movement, aiming, and shooting, complete with animations and recoil.
- **Kill Feed and Leaderboard**: Track player stats in real-time with in-game leaderboards.
- **Audio Design**: Immersive sound effects for weapons, footsteps, and ambient sounds.
- **Health and Respawn**: Dynamic health regeneration and respawn mechanics for continuous action.
- **Lobby System**: Create or join multiplayer rooms, browse available rooms, and seamlessly transition to gameplay.
- **Weapon Inventory**: Switch between multiple weapons dynamically to adapt to different combat scenarios.
- **Dynamic Map Management**: Randomly spawn and manage map elements to ensure unique gameplay experiences every match.

---

## **🎮 How to Play**
1. Host or join a multiplayer room.
2. Select your loadout and prepare for battle.
3. Eliminate opponents to climb the leaderboard.
4. Work with your team or play free-for-all to dominate the arena.

---

## **🔧 Code Overview**

### **Key Scripts**
Here’s a breakdown of the core scripts used in the project:

#### **PlayerController.cs**
- Handles player movement (walking, running, crouching) and camera rotation for first-person perspective.

#### **WeaponSystem.cs**
- Manages weapons, including shooting, reloading, and recoil.

#### **HealthSystem.cs**
- Tracks player health, handles damage, and manages respawn mechanics.

#### **MultiplayerManager.cs**
- Connects players to the server, synchronizes data, and manages game rooms using Photon PUN or Unity Netcode.

#### **LobbyManager.cs**
- Allows players to create, join, and browse multiplayer rooms seamlessly.

#### **WeaponInventory.cs**
- Enables players to dynamically switch between weapons during gameplay.

#### **MapManager.cs**
- Handles spawning and managing dynamic map elements for varied gameplay experiences.

#### **KillFeed.cs**
- Displays player eliminations in real-time during the match.

#### **Leaderboard.cs**
- Tracks and displays player scores.

#### **GameManager.cs**
- Oversees the game state, including starting, ending, and respawn logic.

---

## **📸 Screenshots & Gameplay Videos**
### **Screenshots**
![Gameplay Screenshot](assets/gameplay_screenshot.png)  
![Multiplayer Lobby](assets/multiplayer_lobby.png)  

### **Gameplay Video**
[![Watch the Gameplay](assets/gameplay_thumbnail.png)](https://youtu.be/your-video-link)

---

## **📂 Repository Structure**
```
FPSMultiplayerShooter/
├── Assets/
│   ├── Scripts/
│   │   ├── Player/
│   │   │   ├── PlayerController.cs
│   │   │   ├── HealthSystem.cs
│   │   ├── Weapons/
│   │   │   ├── WeaponSystem.cs
│   │   │   ├── WeaponInventory.cs
│   │   ├── Multiplayer/
│   │   │   ├── MultiplayerManager.cs
│   │   │   ├── LobbyManager.cs
│   │   ├── UI/
│   │   │   ├── KillFeed.cs
│   │   │   ├── Leaderboard.cs
│   │   ├── Environment/
│   │   │   ├── MapManager.cs
│   ├── Prefabs/
│   │   ├── Weapons/
│   │   ├── Map/
│   ├── Scenes/
│   │   ├── Lobby.unity
│   │   ├── GameScene.unity
├── ProjectSettings/
├── README.md
```

---

## **💻 Tech Stack**
- **Engine**: Unity 3D  
- **Networking**: Photon PUN or Unity Netcode  
- **Programming Language**: C#  
- **Platform**: PC  

---

## **📜 License**
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## **🛠️ Future Enhancements**
- Add voice chat for better team communication.
- Implement advanced AI bots for single-player mode.
- Expand maps and introduce more game modes.
