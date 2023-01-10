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
            AkSoundEngine.PostEvent("Play_Target_throw", gameObject);
        }
    }
}
