
using UnityEngine;
using Random = UnityEngine.Random;

public class ParticleExplosion : MonoBehaviour
{
     [SerializeField] private ParticleSystem[] goodExplosions;
     [SerializeField] private ParticleSystem[] badExplosions;
     
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Good"))
        {
            GoodTargetExplsion();
        }
        
        if(collision.gameObject.CompareTag("Bad"))
        {
            BadTargetExplsion();
        }
    }

    private void GoodTargetExplsion()
    {
        int explosionIndex = Random.Range(0, goodExplosions.Length);
        Instantiate(goodExplosions[explosionIndex], transform.position, 
            Quaternion.identity);
    }
    
    private void BadTargetExplsion()
    {
        int explosionIndex = Random.Range(0, badExplosions.Length);
        Instantiate(badExplosions[explosionIndex], transform.position,
            Quaternion.identity);
    }
}
