using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ApplicationManager : MonoBehaviour
{
    
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
