using UnityEngine;



public class TargetScript : MonoBehaviour
{
    private Rigidbody _targetRb;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>();
    }
    
    private void OnDisable()
    {
        transform.Rotate(Vector3.up);
        _targetRb.velocity = Vector3.zero;
    }

  
    
}
