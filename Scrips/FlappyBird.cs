using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FlappyBird : MonoBehaviour
{
    // Start is called before the first frame update

    public enum SetActive
    {
        Alive,
        Dead
    }
    public static SetActive birdActive;


    //private GameObject bird;
    [SerializeField] private GameObject bird1;
    [SerializeField] private GameObject bird2;
    [SerializeField] private GameObject bird3;

    //[SerializeField] private GameObject pointUp;
    //[SerializeField] private GameObject pointDown;

    //[SerializeField] private float jumpForce = 12;
    //[SerializeField] private float gravity = -9.81f;
    //private int activeNum;
    private int birdStyle;
    //float velocity;


    //[SerializeField] private GameObject wallUp;
    //[SerializeField] private GameObject wallDown;
    //[SerializeField] private float maxTime = 1;
    //private float timer = 0;

    private void Start()
    {
        
    }
    private void Awake()
    {
        birdStyle = Option.GetBird();
        //activeNum = 0;
        if (birdStyle == 0)
        {
            birdActive = Bird1.birdActive1;
            birdStyle = 1;
        }
        if (birdStyle == 1)
        {
            birdActive = Bird1.birdActive1;
            bird2.SetActive(false);
            bird3.SetActive(false);
        }
        if (birdStyle == 2)
        {
            birdActive = Bird1.birdActive1;
            bird1.SetActive(false);
            bird3.SetActive(false);
        }
        if (birdStyle == 3)
        {
            birdActive = Bird1.birdActive1;
            bird1.SetActive(false);
            bird2.SetActive(false);
        }

    }
    void Update()
    {
        birdActive = Bird1.birdActive1;
        //if (Input.GetKeyUp(KeyCode.Space) && activeNum == 0)
        //{
        //    birdActive = SetActive.Alive;
        //    activeNum++;
        //}
        //if (birdActive == SetActive.Dead)
        //{
        //    return;
        //}
        //velocity += gravity * Time.deltaTime;
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    velocity = jumpForce;
        //    Sound.instance.Wing();
        //}
        //if(birdStyle == 1)
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
        //VaCham();

    }
    //private void VaCham()
    //{
    //    if ((bird.transform.position.x == Mathf.Round(pointUp.transform.position.x) - 0.5 ||
    //        bird.transform.position.x == Mathf.Round(pointDown.transform.position.x) + 0.5) &&
    //        ((bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5) ||
    //        (bird.transform.position.y <= pointDown.transform.position.y + 1 && bird.transform.position.y > -5)))
    //    {
    //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
    //        gameOver.gameObject.SetActive(true);
    //        Time.timeScale = 0;
    //        Sound.instance.Hit();
    //        //if(bird.transform.position.y > 0f)
    //        //{
    //        //    if(bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5)
    //        //    {
    //        //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
    //        //        gameOver.gameObject.SetActive(true);
    //        //    }
    //        //}
    //        //if (bird.transform.position.y < 0f)
    //        //{
    //        //    if (bird.transform.position.y <= pointDown.transform.position.y + 0.3 && bird.transform.position.y > -5)
    //        //    {
    //        //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
    //        //        gameOver.gameObject.SetActive(true);

    //        //    }
    //        //}

    //    }
    //    if (bird.transform.position.y < -2.8)
    //    {
    //        FlappyBird.birdActive = FlappyBird.SetActive.Dead;
    //        gameOver.gameObject.SetActive(true);
    //        Time.timeScale = 0;
    //        Sound.instance.Die();
    //    }
    //}
    
}
