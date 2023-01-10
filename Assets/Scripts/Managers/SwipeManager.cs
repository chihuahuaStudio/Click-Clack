using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer), typeof(BoxCollider))]
public class SwipeManager : MonoBehaviour
{
    private GameManager _gmScript;
    private PauseManager _pauseScript;
    private Camera _cam;
    private Vector3 _mousPos;
    private TrailRenderer _trail;
    private BoxCollider _col;

    public bool swiping = false;

    private void Awake()
    {
        _cam = Camera.main;
        _trail = GetComponent<TrailRenderer>();
        _col = GetComponent<BoxCollider>();
        _trail.enabled = false;
        _col.enabled = false;
        
    }

    private void UpdateMousePosition()
    {
        _mousPos = _cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
            Input.mousePosition.y, 10.0f));
        transform.position = _mousPos;
    }

    private void UpdateComponents()
    {
        _trail.enabled = swiping;
        _col.enabled = swiping;
    }

    private void Update()
    {
        if(GameManager.Singleton.isGameActive && !PauseManager.Singleton.isGamePaused)
        {
            if(Input.GetMouseButtonDown(0))
            {
                swiping = true;
                Cursor.visible = false;
                UpdateComponents();
            }
            else if(Input.GetMouseButtonUp(0))
            {
                swiping = false;
                Cursor.visible = true;
                UpdateComponents();
            }
            if(swiping)
            {
                UpdateMousePosition();
            } 
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Good") || collision.gameObject.CompareTag("Bad"))
        {
            collision.gameObject.GetComponent<TargetScript>().DestroyTarget();
        }
        
        if(collision.gameObject.CompareTag("Good") && swiping)
        {
            AkSoundEngine.PostEvent("Play_GoodTarget_Sound", gameObject);
        }
        
        if(collision.gameObject.CompareTag("Bad") && swiping)
        {
            AkSoundEngine.PostEvent("Play_Bomb_Target", gameObject);
        }
    }
}
