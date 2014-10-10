using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class LoopingMusicExample : MonoBehaviour
{
    Sound snd;
    public GUIText progressBar;

    void Start() {
        AudioManager am = Camera.main.GetComponent<AudioManager>();
        snd = am.NewSound("Dungeon", loop: true);
    }

    void Update() {
        guiText.text = "BG Music " + (snd.playing ? "▐▐" : "►");
        int progressTo20 = (int)(snd.progress * 20f);
        progressBar.GetComponent<GUIText>().text = "|"+(new string('|', progressTo20))+(new string(' ', 20-progressTo20))+"|";
    }

    void OnMouseDown() {
        snd.playing = !snd.playing;
    }
}
