using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static FlappyBird;

public class Move : MonoBehaviour
{
    public static Move Instance { get; set; }
    public float speed;
    //private GameObject bird;
    [SerializeField] private GameObject[] wall;
    [SerializeField] private GameObject[] target;
    
    private void Awake()
    {
        speed = 2f;
        Instance= this;
    }

    // Update is called once per frame
    void Update()
    {
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
        //wall2.transform.position += Vector3.left * speed * Time.deltaTime;
        if (wall[0].transform.position.x < -4) 
        {
            wall[0].transform.position = new Vector3(4, Random.Range(-1, 1));
            target[0].SetActive(true);
        }
        if (wall[1].transform.position.x < -4)
        {
            wall[1].transform.position = new Vector3(4, Random.Range(-1, 1));
            target[1].SetActive(true);
        }

        

    }
}
