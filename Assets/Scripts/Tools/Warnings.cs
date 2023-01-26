using UnityEngine;

[ExecuteInEditMode]
public class Warnings : MonoBehaviour
{
    private void Awake()
    {
        // Debug.LogWarning("Must add default values to volume controls");
        // Debug.LogWarning("Must refactor target script and swipe manger scripts");
        // Debug.LogWarning("Must find a way to fix physics in target instantiation");
        Debug.LogWarning("Must fix the pool  so it waits until all objects are inactive  to respawn");
    }
    
}
