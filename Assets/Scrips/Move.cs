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

        //if ((bird.transform.position.x == Mathf.Round(pointUp.transform.position.x) - 0.5 ||
        //    bird.transform.position.x == Mathf.Round(pointDown.transform.position.x) + 0.5) &&
        //    ((bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5) ||
        //    (bird.transform.position.y <= pointDown.transform.position.y + 1 && bird.transform.position.y > -5)))
        //{
        //    FlappyBird.birdActive = FlappyBird.SetActive.Dead;
        //    gameOver.gameObject.SetActive(true);
        //    //Time.timeScale = 0;
        //    Sound.instance.Hit();
        //    //if(bird.transform.position.y > 0f)
        //    //{
        //    //    if(bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5)
        //    //    {
        //    //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
        //    //        gameOver.gameObject.SetActive(true);
        //    //    }
        //    //}
        //    //if (bird.transform.position.y < 0f)
        //    //{
        //    //    if (bird.transform.position.y <= pointDown.transform.position.y + 0.3 && bird.transform.position.y > -5)
        //    //    {
        //    //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
        //    //        gameOver.gameObject.SetActive(true);

        //    //    }
        //    //}

        //}
        //if(bird.transform.position.y < -2.8)
        //{
        //    FlappyBird.birdActive = FlappyBird.SetActive.Dead;
        //    gameOver.gameObject.SetActive(true);
        //    //Time.timeScale = 0;
        //    Sound.instance.Die();
        //}

    }
    //((bird.transform.position.y >= point.transform.position.y && bird.transform.position.y <= 5) || (bird.transform.position.y <= point.transform.position.y && bird.transform.position.y >= -5))
}
