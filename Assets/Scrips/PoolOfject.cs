using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolOfject : MonoBehaviour
{

    public static PoolOfject instance;
    private List<GameObject> _pooledObject = new List<GameObject>();
    private int _poolCount = 10;

    [SerializeField] private GameObject _poolPrefab;
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        for (int i = 0; i < _poolCount; i++) 
        {
            GameObject obj = Instantiate(_poolPrefab);
            obj.SetActive(false);
            _pooledObject.Add(obj);
        }
        
    }

    public GameObject GetPoolOfject()
    {
        for (int i = 0; i < _pooledObject.Count; i++)
        {
            if (!_pooledObject[i].activeInHierarchy)
            {
                return _pooledObject[i];
            }
            
        }
        
        GameObject obj = Instantiate(_poolPrefab);
        obj.SetActive(false);
        _pooledObject.Add(obj);
        return obj;
    }
}
