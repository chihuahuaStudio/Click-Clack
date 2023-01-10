using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumMusicGamePlay : MonoBehaviour
{
   public void PlayMediumMusic()
    {
        AkSoundEngine.SetState("Music", "Gameplay_Medium");
    }

   
}
