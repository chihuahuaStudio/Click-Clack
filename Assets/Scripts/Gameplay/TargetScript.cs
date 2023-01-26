using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class TargetScript : MonoBehaviour
{
    private Rigidbody _targetRb;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>();
    }
    
    private void OnDisable()
    {
        transform.rotation = Quaternion.identity;
        _targetRb.velocity = Vector3.zero;
    }

  
    
}
