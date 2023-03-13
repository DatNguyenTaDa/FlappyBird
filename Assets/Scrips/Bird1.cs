using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;
using static FlappyBird;

public class Bird1 : MonoBehaviour
{
    public static bool isCollider;

    private static int score;
    private static int hightScore;
    [SerializeField] private GameObject bird;
    [SerializeField] private float jumpForce;
    [SerializeField] private float gravity;

    [SerializeField] private GameObject[] wall;
    [SerializeField] private GameObject[] targets;
    public static int temp;
    


    [SerializeField] private Canvas gameOver;
    [SerializeField] private Image exhaust;
    [SerializeField] private Image ghost;

    public static float maxTime;
    private float timer;

    float velocity;

    
    // Start is called before the first frame update

    // Update is called once per frame
    public virtual void Awake()
    {
        isCollider = true;
        maxTime = 2f;
        timer = 0;
        hightScore = PlayerPrefs.GetInt("highScore", 0);
        gameOver.gameObject.SetActive(false);
        score = 0;

        temp= 0;

        if(Option.GetBird()==1 || Option.GetBird() == 0)
        {
            exhaust.gameObject.SetActive(false);
            ghost.gameObject.SetActive(false);
        }
        if (Option.GetBird() == 2)
        {
            exhaust.gameObject.SetActive(false);
            ghost.gameObject.SetActive(true);
        }
        if (Option.GetBird() == 3)
        {
            exhaust.gameObject.SetActive(true);
            ghost.gameObject.SetActive(false);
        }
    }
    public virtual void Update()
    {
        if (FlappyBird.birdActive == SetActive.Dead)
        {
            return;
        }
        BirdMove();
        Collider();
        if (timer > maxTime)
        {
            score++;
            timer = 0;
            Debug.Log(score);
            Sound.instance.Point();
        }
        timer += Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.F))
        {
            Fire();
        }
    }
    public static int GetScore()
    {
        return score;
    }
    public static int GetHighScore()
    {
        return hightScore;
    }
    public void BirdMove()
    {
        if (birdActive == SetActive.Dead)
        {
            return;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            velocity = jumpForce;
            Sound.instance.Wing();
        }
        velocity += gravity * Time.deltaTime;

        bird.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
    }
    public void Collider()
    {
        
        if (bird.transform.position.y < -2.8)
        {
            FlappyBird.birdActive = SetActive.Dead;
            gameOver.gameObject.SetActive(true);
            //Time.timeScale = 0;
            Sound.instance.Die();
        }
        if (isCollider)
        {
            //if (targets[1]!=null)
            //{
            //    if (Mathf.Round(bird.transform.position.x) == Mathf.Round(targets[temp].transform.position.x) - 1)
            //    {
            //        if (bird.transform.position.y <= targets[temp].transform.position.y + 0.5f && bird.transform.position.y >= targets[temp].transform.position.y - 0.5f)
            //        {
            //            FlappyBird.birdActive = SetActive.Dead;

            //            gameOver.gameObject.SetActive(true);
            //            //Time.timeScale = 0;
            //            Sound.instance.Hit();

            //        }
            //    }
            //}
            if ((bird.transform.position.x == Mathf.Round(wall[temp].transform.position.x) - 0.5 ||
                bird.transform.position.x == Mathf.Round(wall[temp].transform.position.x) + 0.5) &&
                ((bird.transform.position.y >= wall[temp].transform.position.y + 1.2f && bird.transform.position.y < 5) ||
                 (bird.transform.position.y <= wall[temp].transform.position.y - 1.2f && bird.transform.position.y > -5)))
            {

                FlappyBird.birdActive = SetActive.Dead;

                gameOver.gameObject.SetActive(true);
                //Time.timeScale = 0;
                Sound.instance.Hit();

            }
            else
            {
                temp++;
            }
            Debug.Log(temp);
        }
        if(temp == wall.Length)
        {
            temp = 0;
        }


    }
    public void Fire()
    {
        GameObject bullet = PoolOfject.instance.GetPoolOfject();

        if(bullet != null)
        {
            bullet.transform.position = bird.transform.position;
            bullet.SetActive(true);
            
        }
        
    }
}
