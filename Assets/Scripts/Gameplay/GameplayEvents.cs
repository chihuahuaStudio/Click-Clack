using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameplayEvents : MonoBehaviour
{
    #region Actions

    public delegate void GameEvents();

    public static event Action GoodTargetEvent;

    public static event Action BadTargetEvent;

    #endregion

    public static void RaiseGoodTargetEvent()
    {
        if(GoodTargetEvent != null)
        {
            GoodTargetEvent();
        }
    }

    public static void RaiseBadTargetEvent()
    {
        if(BadTargetEvent != null)
        {
            BadTargetEvent();
        }
    }
}
