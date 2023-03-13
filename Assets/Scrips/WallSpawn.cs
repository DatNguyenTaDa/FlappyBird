using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    
    public static WallSpawn instance;
    [SerializeField] private GameObject wall;
    
    private void Awake()
    {
        GameObject newWall = Instantiate(wall);
        newWall.transform.position = new Vector3(wall.transform.position.x + 4, 0, 0);
        
    }
    
}
