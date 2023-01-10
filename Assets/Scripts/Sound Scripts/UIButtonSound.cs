using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonSound : MonoBehaviour
{
    public void PlayButtonSoundEasy()
    {
        AkSoundEngine.PostEvent("UI_Button_Easy", gameObject);
    }

    public void PlayButtonSoundMedium()
    {
        AkSoundEngine.PostEvent("UI_Button_Medium", gameObject);
    }

    public void PlayButtonSoundHard()
    {
        AkSoundEngine.PostEvent("UI_Button_Hard", gameObject);
    }

    public void PlayAudioButtonSound()
    {
        AkSoundEngine.PostEvent("UI_Button_Audio", gameObject);
    }

    public void PlayHelpButtonSound()
    {
        AkSoundEngine.PostEvent("UI_Button_Help", gameObject);
    }

    public void PlayMainMenuButtonSound()
    {
        AkSoundEngine.PostEvent("UI_Button_Main_Menu", gameObject);
    }

    public void playRestartButtonSound()
    {
        AkSoundEngine.PostEvent("UI_Button_Restart", gameObject);
    }

    public void PlayQuitButtonSound()
    {
        AkSoundEngine.PostEvent("UI_Button_Quit", gameObject);
    }
}
