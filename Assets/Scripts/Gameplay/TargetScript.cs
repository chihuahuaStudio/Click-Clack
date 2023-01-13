
using UnityEngine;
using Random = UnityEngine.Random;


public class TargetScript : MonoBehaviour
{
    private Rigidbody _targetRb;
    private const int RandomForceMin = 12;
    private const int RandomForceMax = 14;
    private const float TorqueForce = 10;
    private const float XMinPos = 4f;
    private const float YPos = 2f;
    
    public ParticleSystem explosion;

    public int pointValue;

    public bool _targetInstatiated;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>(); //reference au Rigidbody du game object
    }
    
    private void OnEnable()
    {
        SetTargetPositionAndForce();
    }
    

    private void Update()
    {
        
        if (_targetRb.gameObject.activeInHierarchy)
        {
            _targetInstatiated = true;
        }
        else
        {
            _targetInstatiated = false;
        }
        
        Debug.Log("Velocity: "+_targetRb.velocity + $"{this.gameObject.name}");
    }
    
    public void DestroyTarget()
    {
        if (GameManager.Singleton.isGameActive && !PauseManager.Singleton.isGamePaused)
        {
            gameObject.SetActive(false);
            Instantiate(explosion, transform.position, explosion.transform.rotation);
            ScoreManager.Singleton.ScoreUpdate(pointValue);
        }
    }
    
    private void SetTargetPositionAndForce()
    {
        Vector3 force = RandomForce();
        if (_targetInstatiated)
        {
            Debug.Log(" Force: "+force + $"of {gameObject.name}");
        }
        
        transform.localPosition = RandomSpawnPosition() ; //position aleatoires par defaults des items
        _targetRb.AddRelativeForce(force, ForceMode.Impulse); //ligne pour applique  de la force dans l'axe des Y
        _targetRb.AddRelativeTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); //application du torque pour crer des rotations
 
    }



    private Vector3 RandomForce()
    {
        Vector3 force = Vector3.up * Random.Range(RandomForceMin, RandomForceMax);
        return force;
    }

    private float RandomTorque()
    {
        return Random.Range(-TorqueForce, TorqueForce);
    }

    private Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-XMinPos, XMinPos), -YPos, 10.0f);
    }
}
