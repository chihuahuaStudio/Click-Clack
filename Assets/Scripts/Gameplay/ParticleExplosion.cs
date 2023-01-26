
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
            // GoodTargetExplsion();
            int explosionIndex = Random.Range(0, goodExplosions.Length);
            Instantiate(goodExplosions[explosionIndex], collision.transform.position, 
                Quaternion.identity);
        }
        
        if(collision.gameObject.CompareTag("Bad"))
        {
            // BadTargetExplsion();
            int explosionIndex = Random.Range(0, badExplosions.Length);
            Instantiate(badExplosions[explosionIndex], collision.transform.position,
                Quaternion.identity);
        }
    }

    private void GoodTargetExplsion()
    {

    }
    
    private void BadTargetExplsion()
    {
   
    }
}
