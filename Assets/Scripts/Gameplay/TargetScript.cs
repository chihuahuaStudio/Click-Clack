
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Random = UnityEngine.Random;


public class TargetScript : MonoBehaviour
{
    private Rigidbody _targetRb;
    private const int RandomForceMin = 12;
    private const int RandomForceMax = 16;
    private const float TorqueForce = 10;
    private const float XMinPos = 4f;
    private const float YPos = 2f;
    
    public ParticleSystem explosion;

    public int pointValue;

    private void Awake()
    {
        _targetRb = GetComponent<Rigidbody>(); //reference au Rigidbody du game object
        // _targetRb.isKinematic = true;
    }
    
    private void OnEnable()
    {
        SetTargetpositionAndForce();
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
    
    private void SetTargetpositionAndForce()
    {
        _targetRb.isKinematic = false;
        transform.localPosition = RandomSpawnPosition() ; //position aleatoires par defaults des items
        _targetRb.AddForce(RandomForce(), ForceMode.Impulse); //ligne pour applique  de la force dans l'axe des Y
        _targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); //application du torque pour crer des rotations
    }


    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        // _targetRb.isKinematic = true;
    
        if (!gameObject.CompareTag("Bad"))
        {
            GameManager.Singleton.GameOver();
            LivesManager.UpdateLivesLeft();
        }
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(RandomForceMin, RandomForceMax);
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
