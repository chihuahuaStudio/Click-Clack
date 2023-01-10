using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSounds : MonoBehaviour
{
    private void OnMouseDown()
    {
        AkSoundEngine.PostEvent("Play_Bomb_Target", gameObject);
    }
}
