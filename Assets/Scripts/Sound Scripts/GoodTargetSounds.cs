using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTargetSounds : MonoBehaviour
{

    public AK.Wwise.Event goodTargetSound;

    private void Update()
    {
        //only for enable function
    }

    private void OnMouseDown()
    {
        if(!PauseManager.Singleton.isGamePaused)
        {
            goodTargetSound.Post(gameObject);
        }
       
    }
}
