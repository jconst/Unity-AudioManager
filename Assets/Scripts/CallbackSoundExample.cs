using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CallbackSoundExample : MonoBehaviour
{
    Sound snd;
    public GameObject progressBar;

    void Start() {
        snd = AudioManager.Main.NewSound("NewItem", interrupts: true, callback: delegate(Sound s) {
            GUIText callbackAlert = GameObject.Find("CallbackWasCalled").GetComponent<GUIText>();
            callbackAlert.enabled = true;
            callbackAlert.color = new Color(UnityEngine.Random.value,
                                            UnityEngine.Random.value,
                                            UnityEngine.Random.value,
                                            1);
        });
    }

    void Update() {
        guiText.text = "Interrupt. Sound w/ Callback " + (snd.playing ? "▐▐" : "►");
        int progressTo20 = (int)(snd.progress * 20f);
        progressBar.GetComponent<GUIText>().text = "|"+(new string('|', progressTo20))+(new string(' ', 20-progressTo20))+"|";
    }

    void OnMouseDown() {
        snd.playing = !snd.playing;
    }
}
