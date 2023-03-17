using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;
using static FlappyBird;

public class Bird1 : MonoBehaviour
{
    public static Bird1 instance;
    public bool isCollider;

    private int score;
    private  int hightScore;
    [SerializeField] private GameObject bird;
    public float jumpForce;
    public float gravity;

    public List<GameObject> wall =  new List<GameObject>();
    public GameObject[] targets;
    public static int[] isScore;
    public int temp;



    [SerializeField] private Canvas gameOver;
    [SerializeField] private Image exhaust;
    [SerializeField] private Image ghost;


    float velocity;

    
    // Start is called before the first frame update

    // Update is called once per frame
    public virtual void Awake()
    {
        instance = this;

        //wall = new GameObject[Move.instance.GetWallLenght()];
        //wall = new GameObject[Move.wall.Length];
        //for (int i = 0; i < Move.wall.Length; i++)
        //{
        //    wall[i] = Move.wall[i];
        //}
        isCollider = true;
        gameOver.gameObject.SetActive(false);
        score = 0;
        hightScore = PlayerPrefs.GetInt("superHighScore", 0);
        temp = 0;
        
        if (Option.GetBird() == 1 || Option.GetBird() == 0)
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
        //if (timer > maxTime)
        //{
        //    score++;
        //    timer = 0;
        //    Sound.instance.Point();
        //}
        //timer += Time.deltaTime;
        if(score > hightScore)
        {
            hightScore =  PlayerPrefs.GetInt("superHighScore", score);
            PlayerPrefs.SetInt("superHighScore", score);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            Fire();
        }
    }
    public virtual void Start()
    {
        wall = Move.instance.GetArray();
        isScore = new int[wall.Count];

        isScore[0] = 1;
        isScore[1] = 1;
    }
    public int GetScore()
    {
        return instance.score;
    }
    public  int GetHighScore()
    {
        return instance.hightScore;
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

        bird.transform.position += new Vector3(0, velocity, 0) * Time.deltaTime;
        //float angle = 0f;
        //if (/*bird.transform.position.y < 0 ||*/ bird.transform.position.y > 0)
        //{
        //    angle = Mathf.Lerp(0, -80, -bird.transform.position.y / jumpForce);
        //    Debug.Log("nghieng dau");
        //}
        //bird.transform.rotation = Quaternion.Euler(0,0, Mathf.Lerp(0, -80, -bird.transform.position.y / jumpForce));
        //bird.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
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
        if (isScore[0] == 1)
        {
            if (bird.transform.position.x > wall[0].transform.position.x)
            {
                score++;
                isScore[0] = 0;
                Sound.instance.Point();

            }
        }
        if (isScore[1] == 1)
        {
            if (bird.transform.position.x > wall[1].transform.position.x)
            {
                
                score++;
                isScore[1] = 0;
                Sound.instance.Point();
            }
        }
        if (isCollider)
        {
            if (targets[temp].activeInHierarchy == true)
            {
                if (Mathf.Round(bird.transform.position.x) == Mathf.Round(targets[temp].transform.position.x) - 1 &&
                (bird.transform.position.y <= targets[temp].transform.position.y + 0.5f &&
                bird.transform.position.y >= targets[temp].transform.position.y - 0.5f))
                {
                    FlappyBird.birdActive = SetActive.Dead;

                    gameOver.gameObject.SetActive(true);
                    //Time.timeScale = 0;
                    Sound.instance.Hit();
                }
            }
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
        }
        if(temp == wall.Count)
        {
            temp = 0;
        }


    }
    public void Score()
    {

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
