using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMainTheme : MonoBehaviour
{
    
    public void Start()
    {
 
        AkSoundEngine.PostEvent("Play_Music", gameObject);
       
    }

}
