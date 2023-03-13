using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using static FlappyBird;

public class Move : MonoBehaviour
{
    public static float speed;
    //private GameObject bird;
    [SerializeField] private GameObject[] wall;
    [SerializeField] private GameObject[] target;
    //[SerializeField] private GameObject wall2;
    //[SerializeField] private GameObject bird1;
    //[SerializeField] private GameObject bird2;
    //[SerializeField] private GameObject bird3;
    //[SerializeField] private GameObject pointUp;
    //[SerializeField] private GameObject pointDown;
    // Start is called before the first frame updat

    
    private void Awake()
    {
        speed = 2f;
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
