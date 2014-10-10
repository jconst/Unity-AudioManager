Unity-AudioManager
==================

An easy, versatile way to play and manage multiple different sounds in Unity.
Play a sound file from your "Resources" folder in just one line of code!
```csharp
AudioManager.Main.PlayNewSound("GotNewItem");
```

Installation
--------------

1. Drag AudioManager.cs and Sound.cs (from Assets/Scripts in this project) into your project's Assets folder.

2. AudioManager is a MonoBehaviour which expects to be attached to the Main Camera, so attach it there now.

3. Ensure all of your sounds are in a folder called `Resources`. (This is so that the function `Resources.Load()` will work, and is Unity's limitation, not mine.)


Usage
---------

For the majority of sounds, you'll just need to play them and forget about it, so for that, use AudioManager's PlayNewSound function:

```csharp
AudioManager.Main.PlayNewSound("GotNewItem");
```

The AudioManager will add a new AudioSource to your Main Camera to play the sound, because each Audio Source can only play one sound at a time. Don't worry, the Component will be removed when the sound finishes playing!

---

For more customization, AudioManager's functions PlayNewSound and NewSound take a few useful parameters to affect what happens when the sound is played:

```csharp
Sound newSound = AudioManager.Main.NewSound("BGMusic", loop: true, interrupts: false);
```

Setting "interrupts" to true will cause the sound to pause all other sounds when it plays. This is like the sound that plays when Mario dies, or when Link finds a secret room. The "loop" option should be self-explanatory.

---

As you can see, NewSound also returns a Sound object, which can be interacted with later. For example, implementing a toggle button would be as easy as this:

 ```csharp
void OnMouseDown() {
    sound.playing = !sound.playing;
}
```

---

This tool also has other capabilities like adding callbacks to sounds and reading their time progress as a float. For examples of these features, check out the `*Example.cs` scripts in `Assets/Scripts`.

Author
---------
Joseph Constantakis
constanj@umich.edu
