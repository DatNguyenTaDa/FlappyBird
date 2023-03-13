using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    private static int score;
    private static int hightScore;
    private static WallSpawn instance;
    [SerializeField] private GameObject wall;
    //[SerializeField] private GameObject wallDown;
    [SerializeField] private float maxTime = 1;
    [SerializeField] private float timer = 0;
    [SerializeField] private float height = 1;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        hightScore = PlayerPrefs.GetInt("highScore",0);
        score = 0;
        GameObject newWall = Instantiate(wall);
        newWall.transform.position = transform.position + new Vector3(2, Random.Range(-height, height), 0);
        //GameObject newWallDown = Instantiate(wallDown);
        //newWallDown.transform.position = transform.position + new Vector3(2, Random.Range(-4, -6), 0);
        //newWallUp.transform.rotation = Quaternion.Euler(0, 0, 180);
        Destroy(newWall,10);

    }
    public static int GetScore()
    {
        return score;
    }
    public static int GetHighScore()
    {
        return hightScore;
    }
    // Update is called once per frame
    void Update()
    {

        if (FlappyBird.birdActive == FlappyBird.SetActive.Dead)
        {
            return;
        }
        if (timer > maxTime)
        {
            
            GameObject newWall = Instantiate(wall);
            newWall.transform.position = transform.position + new Vector3(2, Random.Range(-height, height), 0);
            Destroy(newWall, 10);
            //GameObject newWallDown = Instantiate(wallDown);
            //newWallDown.transform.position = transform.position + new Vector3(3, Random.Range(-4, -6), 0);
            ////newWallUp.transform.rotation = Quaternion.Euler(0,0,180);
            //Destroy(newWallUp, 15);
            //Destroy(newWallDown, 15);
            timer = 0;
            score++;
            if(score > hightScore)
            {
                PlayerPrefs.SetInt("highScore", score);
            }    
            Debug.Log(score);
            Sound.instance.Point();

        }
        timer += Time.deltaTime;
    }
}
