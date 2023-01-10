using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyMusicGameplay : MonoBehaviour
{
    public void PlayEasyMusic()
    {
        AkSoundEngine.SetState("Music", "Gameplay_Easy");
    }
}
