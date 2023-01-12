using UnityEngine;

public class MusicMainTheme : MonoBehaviour
{
    
    public void Start()
    {
 
        AkSoundEngine.PostEvent("Play_Music", gameObject);
       
    }

}
