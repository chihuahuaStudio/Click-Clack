using UnityEngine;

public class ButtonDifficulty : MonoBehaviour
{
    private const float SPAWN_RATE_START_VALUE = 1.0f;
    public static float SpawnRate;



   public void SetDifficulty(float setDificulty)
   {
       SpawnRate = SPAWN_RATE_START_VALUE / setDificulty;
   }
}
