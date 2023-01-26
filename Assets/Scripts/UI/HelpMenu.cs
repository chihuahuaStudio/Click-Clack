using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMenu : MonoBehaviour
{
    [SerializeField] GameObject startScreen;
    [SerializeField] GameObject helpScreen;
    [SerializeField] Button helpButton;
    [SerializeField] Button mainMenu;

    // private void Awake()
    // {
    //     helpButton.onClick.AddListener(LoadHelpMenu);
    //     mainMenu.onClick.AddListener(LoadMainMenu);
    // }
    //
    // private void LoadMainMenu()
    // {
    //     helpScreen.SetActive(false);
    //     startScreen.SetActive(true);
    // }
    //
    // private void LoadHelpMenu()
    // {
    //     startScreen.SetActive(false);
    //     helpScreen.SetActive(true);
    // }
}
