using UnityEngine;

[ExecuteInEditMode]
public class Warnings : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogWarning("Must add default values to volume controls");
    }
    
}
