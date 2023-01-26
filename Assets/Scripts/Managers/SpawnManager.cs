using System.Collections;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    
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
            if (target != null) target.SetActive(true);
            SetTargetPositionAndForce(target.gameObject.GetComponent<Rigidbody>());
            AkSoundEngine.PostEvent("Play_Target_throw", gameObject);
        }
    }
    
    private void SetTargetPositionAndForce(Rigidbody _targetRb)
    {
        Vector3 force = RandomForce()
            ;
        // Debug.Log(" Force: "+force + $"of {gameObject.name}");
       _targetRb.transform .localPosition = RandomSpawnPosition() ;
        _targetRb.AddRelativeForce(force, ForceMode.Impulse);
        _targetRb.AddRelativeTorque(RandomTorque(), 
            RandomTorque(), 
            RandomTorque(), 
            ForceMode.Impulse);
    }
    
    private Vector3 RandomForce()
    {
        const int RandomForceMin = 13;
        const int RandomForceMax = 14;
        
        Vector3 force = Vector3.up * 
                        Random.Range(RandomForceMin, RandomForceMax);
        return force;
    }
    
    private float RandomTorque()
    {
        const int TorqueForce = 10;
        return Random.Range(-TorqueForce, TorqueForce);
    }
    
    private Vector3 RandomSpawnPosition()
    {
        float XMinPos = 4.0f;
        float YPos = 2.0f;
        return new Vector3(Random.Range(-XMinPos, XMinPos), -YPos, 10.0f);
    }
}
