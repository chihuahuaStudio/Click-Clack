using UnityEngine;
using UnityEngine.UI;


public class VolumeControls : MonoBehaviour
{
    [SerializeField] GameObject startScreen;
    [SerializeField] GameObject audioScreen;
    [SerializeField] Button mainMenu;
    [SerializeField] Button audioButton;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] string musicParameter = "musicSliderValue;";
    [SerializeField] string masterParameter = "masterSliderValue";
    [SerializeField] string sfxParameter = "sfxSliderValue";

    private const float DEFAULT_SLIDER_VALUE = 75.0f;

    private void Awake()
    {
        mainMenu.onClick.AddListener(ReturnToMainMenu);
        audioButton.onClick.AddListener(LoadAudioControls);
        masterSlider.onValueChanged.AddListener(MasterVolumeControl);
        musicSlider.onValueChanged.AddListener(MusicVolumeControl);
        sfxSlider.onValueChanged.AddListener(SFXVolumeControl);

        masterSlider.value = PlayerPrefs.GetFloat(masterParameter, masterSlider.value);
        musicSlider.value = PlayerPrefs.GetFloat(musicParameter, musicSlider.value);
        sfxSlider.value = PlayerPrefs.GetFloat(sfxParameter, sfxSlider.value);
    }

    private void Start()
    {
        masterSlider.value = DEFAULT_SLIDER_VALUE;
        musicSlider.value = DEFAULT_SLIDER_VALUE;
        sfxSlider.value = DEFAULT_SLIDER_VALUE;

    }

    private void SFXVolumeControl(float arg0)
    {
        AkSoundEngine.SetRTPCValue("SFX_Volume", sfxSlider.value);
    }

    private void MusicVolumeControl(float arg0)
    {
        AkSoundEngine.SetRTPCValue("Music_Volume", musicSlider.value);
    }

    private void MasterVolumeControl(float arg0)
    {

        AkSoundEngine.SetRTPCValue("Master_Volume", masterSlider.value);
    }

    private void LoadAudioControls()
    {
        audioScreen.SetActive(true);
        startScreen.SetActive(false);
    }

    private void ReturnToMainMenu()
    {
        audioScreen.SetActive(false);
        startScreen.SetActive(true);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(masterParameter, masterSlider.value);
        PlayerPrefs.SetFloat(musicParameter, musicSlider.value);
        PlayerPrefs.SetFloat(sfxParameter, sfxSlider.value);
    }
}
