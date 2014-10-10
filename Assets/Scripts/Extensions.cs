using UnityEngine;

public static class Extensions
{
    public static AudioManager AudioMgr() {
        return Camera.main.GetComponent<AudioManager>();
    }
}
