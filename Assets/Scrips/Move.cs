using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static FlappyBird;

public class Move : MonoBehaviour
{
    public static Move instance;
    public float speed;
    //private GameObject bird;
    [SerializeField] private List<GameObject> wall = new List<GameObject>();
    [SerializeField] private GameObject[] target;

    
    private void Awake()
    {
        instance= this;
        //if (Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x * 2f >
        //    MathF.Abs(wall[0].transform.position.x - wall[1].transform.position.x) * 1.5f)
        //{
        //    GameObject newWall = Instantiate(wall[0]);
        //    newWall.transform.position = new Vector2(wall[1].transform.position.x + 4, 0);
        //    wall.Add(newWall);
        //    wall[wall.Count - 1] = newWall;
        //}
    }
    //private void Start()
    //{
    //    if (Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x * 2f > Vector2.Distance(wall[0].transform.position, wall[1].transform.position) * 1.5)
    //    {
    //        Array.Resize(ref wall, wall.Length + 1);
    //        GameObject newWall = Instantiate(wall[0]);
    //        newWall.transform.position = new Vector2(wall[1].transform.position.x + 4, 0);
    //        wall[wall.Length - 1] = newWall;
    //    }
    //}

    // Update is called once per frame
    public List<GameObject> GetArray()
    {
        return wall;
    }
    public int GetWallLenght()
    {
        return wall.Count;
    }
    void Update()
    {
        if(Bird1.instance.GetScore() >= 5)
        {
            speed = 3f;
        }
        //if (Input.GetKeyUp(KeyCode.Space) && activeNum == 0)
        //{
        //    birdActive = SetActive.Alive;
        //    activeNum++;
        //}
        if (FlappyBird.birdActive == FlappyBird.SetActive.Dead)
        {
            return;
        }
        wall[0].transform.position += Vector3.left * speed * Time.deltaTime;
        wall[1].transform.position += Vector3.left * speed * Time.deltaTime;
        if (wall.Count > 2)
        {
            wall[2].transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //wall2.transform.position += Vector3.left * speed * Time.deltaTime;
        //if (Camera.main.ScreenToViewportPoint().x > 0)
        if (wall[0].transform.position.x < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 0.5f) 
        {
            wall[0].transform.position = new Vector3(4, UnityEngine.Random.Range(-1, 1));
            target[0].SetActive(true);
            Bird1.isScore[0] = 1;
        }
        if (wall[1].transform.position.x < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 0.5f)
        {
            wall[1].transform.position = new Vector3(4, UnityEngine.Random.Range(-1, 1));
            target[1].SetActive(true);
            Bird1.isScore[1] = 1;
        }
        if (wall.Count > 2)
        {
            if (wall[2].transform.position.x < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 0.5f)
                wall[2].transform.position = new Vector3(4, UnityEngine.Random.Range(-1, 1));
            //target[1].SetActive(true);
            //Bird1.isScore[1] = 1;
        }



    }
}
