using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Good") || 
            collision.gameObject.CompareTag("Bad"))
        {
            ScoreManager.Singleton.
                ScoreUpdate(collision.gameObject.
                    GetComponent<TargetPointValue>().PointValue);
            collision.gameObject.SetActive(false);
        }
        
        if(collision.gameObject.CompareTag("Good"))
        {
            AkSoundEngine.PostEvent("Play_GoodTarget_Sound", gameObject);
        }
        
        if(collision.gameObject.CompareTag("Bad"))
        {
            AkSoundEngine.PostEvent("Play_Bomb_Target", gameObject);
        }
    }


}
