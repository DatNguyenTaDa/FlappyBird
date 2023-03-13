using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird1 : MonoBehaviour
{
    
    public static FlappyBird.SetActive birdActive1;


    [SerializeField] private GameObject bird;
    

    [SerializeField] private GameObject pointUp;
    [SerializeField] private GameObject pointDown;

    [SerializeField] private float jumpForce = 12;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private Canvas gameOver;
    private int activeNum;
    float velocity;


    //[SerializeField] private GameObject wallUp;
    //[SerializeField] private GameObject wallDown;
    //[SerializeField] private float maxTime = 1;
    //private float timer = 0;

    private void Start()
    {

    }
    private void Awake()
    {
        gameOver.gameObject.SetActive(false);
        birdActive1 = FlappyBird.SetActive.Dead;
        //birdStyle = Option.GetBird();
        activeNum = 0;
        //if (birdStyle == 0)
        //{
        //    bird = bird1;
        //    birdStyle = 1;
        //}
        //if (birdStyle == 1)
        //{
        //    bird = bird1;
        //    bird2.SetActive(false);
        //    bird3.SetActive(false);
        //}
        //if (birdStyle == 2)
        //{
        //    bird = bird2;
        //    bird1.SetActive(false);
        //    bird3.SetActive(false);
        //}
        //if (birdStyle == 3)
        //{
        //    bird = bird3;
        //    bird1.SetActive(false);
        //    bird2.SetActive(false);
        //}

    }
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space) && activeNum == 0)
        {
            birdActive1 = FlappyBird.SetActive.Alive;
            activeNum++;
        }
        if (birdActive1 == FlappyBird.SetActive.Dead)
        {
            return;
        }
        velocity += gravity * Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            velocity = jumpForce;
            Sound.instance.Wing();
        }
        bird.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        //if (birdStyle == 1)
        //{
        //    bird1.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        //}
        //if (birdStyle == 2)
        //{
        //    bird2.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        //}
        //if (birdStyle == 3)
        //{
        //    bird3.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        //}
        VaCham();

    }
    private void VaCham()
    {
        if ((bird.transform.position.x == Mathf.Round(pointUp.transform.position.x) - 0.5 ||
            bird.transform.position.x == Mathf.Round(pointDown.transform.position.x) + 0.5) &&
            ((bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5) ||
            (bird.transform.position.y <= pointDown.transform.position.y + 1 && bird.transform.position.y > -5)))
        {
            birdActive1 = FlappyBird.SetActive.Dead;
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            Sound.instance.Hit();
            //if(bird.transform.position.y > 0f)
            //{
            //    if(bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5)
            //    {
            //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
            //        gameOver.gameObject.SetActive(true);
            //    }
            //}
            //if (bird.transform.position.y < 0f)
            //{
            //    if (bird.transform.position.y <= pointDown.transform.position.y + 0.3 && bird.transform.position.y > -5)
            //    {
            //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
            //        gameOver.gameObject.SetActive(true);

            //    }
            //}

        }
        if (bird.transform.position.y < -2.8)
        {
            birdActive1 = FlappyBird.SetActive.Dead;
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            Sound.instance.Die();
        }
    }
}
