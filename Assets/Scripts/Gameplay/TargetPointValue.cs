
using UnityEngine;

public class TargetPointValue : MonoBehaviour
{

    [SerializeField] private TargetScriptableObject targetData;

    public int PointValue { get; private set; }

    void Start()
    {
        PointValue = targetData.pointValue;
    }


}
