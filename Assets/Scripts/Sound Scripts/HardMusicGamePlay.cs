using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardMusicGamePlay : MonoBehaviour
{
    public void PlayHardMusic()
    {
        AkSoundEngine.SetState("Music", "Gameplay_Hard");
    }

    
    
}
