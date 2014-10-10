using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleSoundExample : MonoBehaviour
{
    void OnMouseDown() {
        AudioManager.Main.PlayNewSound("MediumItem");
    }
}
