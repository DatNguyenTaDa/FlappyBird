using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Move : MonoBehaviour
{
    
    [SerializeField] private float speed;
    //private GameObject bird;
    //[SerializeField] private GameObject bird1;
    //[SerializeField] private GameObject bird2;
    //[SerializeField] private GameObject bird3;
    //[SerializeField] private GameObject pointUp;
    //[SerializeField] private GameObject pointDown;
    //[SerializeField] private Canvas gameOver;
    //private int birdStyle;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //birdStyle = Option.GetBird();
        //gameOver.gameObject.SetActive(false);
        //if (birdStyle == 0)
        //{
        //    bird = bird1;
        //}
        //if (birdStyle == 1)
        //{
        //    bird = bird1;
        //}
        //if (birdStyle == 2)
        //{
        //    bird = bird2;
        //}
        //if (birdStyle == 3)
        //{
        //    bird = bird3;
        //}
    }
    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FlappyBird.birdActive == FlappyBird.SetActive.Dead)
        {
            Debug.Log("dead");
            return;
        }
        transform.position += Vector3.left * speed * Time.deltaTime;

        
        //if ((bird.transform.position.x == Mathf.Round(pointUp.transform.position.x) - 0.5 ||
        //    bird.transform.position.x == Mathf.Round(pointDown.transform.position.x) + 0.5) &&
        //    ((bird.transform.position.y >= pointUp.transform.position.y - 0.3 && bird.transform.position.y < 5) ||
        //    (bird.transform.position.y <= pointDown.transform.position.y + 1 && bird.transform.position.y > -5)))
        //{
        //    FlappyBird.birdActive = FlappyBird.SetActive.Dead;
        //    gameOver.gameObject.SetActive(true);
        //    Time.timeScale = 0;
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
        //    Time.timeScale = 0;
        //    Sound.instance.Die();
        //}

    }
    //((bird.transform.position.y >= point.transform.position.y && bird.transform.position.y <= 5) || (bird.transform.position.y <= point.transform.position.y && bird.transform.position.y >= -5))
}
