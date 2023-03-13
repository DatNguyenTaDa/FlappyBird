using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    //private static int score;
    //private static int hightScore;
    public static WallSpawn instance;
    [SerializeField] private GameObject wall;
    //[SerializeField] private GameObject wallDown;
    //public static float maxTime;
    //[SerializeField] private float timer = 0;
    //[SerializeField] private float height = 1;
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject newWall = Instantiate(wall);
        newWall.transform.position = new Vector3(wall.transform.position.x + 4, 0, 0);
        //maxTime = 2;
        //instance = this;
    }
    void Start()
    {
        
        //score = 0;
        //GameObject newWall = Instantiate(wall);
        //newWall.transform.position = transform.position + new Vector3(2, Random.Range(-height, height), 0);
        ////GameObject newWallDown = Instantiate(wallDown);
        ////newWallDown.transform.position = transform.position + new Vector3(2, Random.Range(-4, -6), 0);
        ////newWallUp.transform.rotation = Quaternion.Euler(0, 0, 180);
        //Destroy(newWall,15);

    }
    
    // Update is called once per frame
    //void Update()
    //{
    //    if (FlappyBird.birdActive == FlappyBird.SetActive.Dead)
    //    {
    //        return;
    //    }
    //    if (timer > maxTime)
    //    {
            
    //        GameObject newWall = Instantiate(wall);
    //        newWall.transform.position = transform.position + new Vector3(2, Random.Range(-height, height), 0);
    //        //GameObject newWallDown = Instantiate(wallDown);
    //        //newWallDown.transform.position = transform.position + new Vector3(3, Random.Range(-4, -6), 0);
    //        ////newWallUp.transform.rotation = Quaternion.Euler(0,0,180);
    //        //Destroy(newWallUp, 15);
    //        //Destroy(newWallDown, 15);
    //        timer = 0;
    //        score++;
    //        if(score > hightScore)
    //        {
    //            PlayerPrefs.SetInt("highScore", score);
    //        }    
    //        Debug.Log(score);
    //        Sound.instance.Point();

    //    }
    //    timer += Time.deltaTime;
    //}
}
