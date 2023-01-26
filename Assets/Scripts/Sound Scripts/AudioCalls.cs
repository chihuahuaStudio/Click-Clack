using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCalls : MonoBehaviour
{
    public static AudioCalls Singleton { get; private set; }
    
    [SerializeField] private AK.Wwise.Event pauseWwiseEvent;
    [SerializeField] private AK.Wwise.Event unPauseWwiseEvent;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }

        Singleton = this;
    }

    public void PostWwisePauseEvent()
    {
        pauseWwiseEvent.Post(gameObject);
    }

    public void PostWwiseUnPauseEvent()
    {
        unPauseWwiseEvent.Post(gameObject);
    }

}
