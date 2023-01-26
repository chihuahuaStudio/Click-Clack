using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;


public class SpawnManager : MonoBehaviour
{
    [FormerlySerializedAs("RandomForceMin1")]
    [Header("Target Spawn Settings")]
    [SerializeField] private int randomForceMin1;
    [SerializeField] private int randomForceMax;
    [SerializeField] private int torqueForce;
    [SerializeField] private float xMinSpawnPos;
     [SerializeField] private float yMinSpawnPos;

    public void StartSpawning()
    {
        StartCoroutine(SpawnTarget());
    }
    
    private IEnumerator SpawnTarget()
    {
        while(GameManager.Singleton.isGameActive)
        {
            yield return new WaitForSeconds(ButtonDifficulty.SpawnRate);
            GameObject target = PoolManager.Singleton.TakeItem();
            if (target != null)
            {
                target.SetActive(true);
                SetTargetPositionAndForce(target.gameObject.GetComponent<Rigidbody>());
                AkSoundEngine.PostEvent("Play_Target_throw", gameObject);
            }
          
        }
    }
    
    private void SetTargetPositionAndForce(Rigidbody _targetRb)
    {
        Vector3 force = RandomForce();
        _targetRb.transform .localPosition = RandomSpawnPosition() ;
        _targetRb.AddRelativeForce(force, ForceMode.Impulse);
        _targetRb.AddRelativeTorque(RandomTorque(), 
            RandomTorque(), 
            RandomTorque(), 
            ForceMode.Impulse);
    }
    
    private Vector3 RandomForce()
    {
        Vector3 force = Vector3.up * 
                        Random.Range(randomForceMin1, randomForceMax);
        return force;
    }
    
    private float RandomTorque()
    {
        return Random.Range(-torqueForce, torqueForce);
    }
    
    private Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xMinSpawnPos, xMinSpawnPos), -yMinSpawnPos, 10.0f);
    }


}
