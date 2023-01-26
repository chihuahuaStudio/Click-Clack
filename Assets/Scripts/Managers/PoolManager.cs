using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class PoolItems
{
    [Header("Pool")]
    public GameObject prefab;
    public int amount;
}
public class PoolManager : MonoBehaviour
{
    public static PoolManager Singleton { get; private set; }

    [Header("Pool Manager Settings")] 
    [Header("List of items to pool")]
    [SerializeField] private List<PoolItems> badItems;
    [SerializeField] private List<PoolItems> goodItems;

    [Header("List of pooled items")] 
    [SerializeField] private List<GameObject> pooledItems;

    private Transform _transform;
    
    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }

        Singleton = this;
        _transform = transform;

        pooledItems = new List<GameObject>();

    }
    
    void Start()
    {
        PopulateBadItemList();
        PopulateGoodItemList();
    }
    
    private void PopulateBadItemList()
    {
        GameObject badItemsParentGameObject = Instantiate(new GameObject("BadItems"), _transform);
        Transform badTransform = badItemsParentGameObject.transform;
        if (badItems.Count > 0)
        {
            foreach (var badItem in badItems)
            {
                for (int i = 0; i < badItem.amount; i++)
                {
                    GameObject go = Instantiate(badItem.prefab, badTransform);
                    go.transform.localPosition = transform.position;
                    go.transform.localRotation = Quaternion.identity;
                    go.SetActive(false);
                    pooledItems.Add(go);
                }
            }
        }
    }

    private void PopulateGoodItemList()
    {
        
        GameObject goodItemsParentGameObject = Instantiate(new GameObject("GoodItems"), _transform);
        Transform goodTransform = goodItemsParentGameObject.transform;
        
        if (goodItems.Count > 0)
        {
            foreach (var goodItem in goodItems)
            {
                for (int i = 0; i < goodItem.amount; i++)
                {
                    GameObject go = Instantiate(goodItem.prefab, goodTransform);
                    go.SetActive(false);
                    pooledItems.Add(go);
                }
            }
        }
        
    }

    public GameObject TakeItem()
    {
        int index = Random.Range(0, pooledItems.Count);
        for (int i = 0; i < pooledItems.Count; i++)
        {
            GameObject target = pooledItems[i];

            if (!target.activeInHierarchy)
            {
                if(!pooledItems[index].activeInHierarchy) return pooledItems[index];
            }
        }
        return null;
    }
}
