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


    [SerializeField] private GameObject bird1;
    [SerializeField] private GameObject bird2;
    [SerializeField] private GameObject bird3;
    //[SerializeField] private float jumpForce = 12;
    //[SerializeField] private float gravity = -9.81f;
    private int activeNum;
    private int birdStyle;


    //[SerializeField] private GameObject wallUp;
    //[SerializeField] private GameObject wallDown;
    //[SerializeField] private float maxTime = 1;
    //private float timer = 0;

    //private void Start()
    //{
        
    //}
    private void Awake()
    {
        
        birdActive = SetActive.Dead;
        birdStyle = Option.GetBird();
        activeNum = 0;
        if (birdStyle == 0)
        {
            bird2.SetActive(false);
            bird3.SetActive(false);
        }
        if (birdStyle == 1)
        {
            bird2.SetActive(false);
            bird3.SetActive(false);
        }
        if (birdStyle == 2)
        {
            bird1.SetActive(false);
            bird3.SetActive(false);
        }
        if (birdStyle == 3)
        {
            bird1.SetActive(false);
            bird2.SetActive(false);
        }

    }
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space) && activeNum == 0)
        {
            Time.timeScale = 1;
            birdActive = SetActive.Alive;
            activeNum++;
        }
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
        //if(Option.birdStyle == 1)
        //{
        //    bird1.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        //    bird2.active = false;
        //} else if(Option.birdStyle == 2)
        //{
        //    bird2.transform.Translate(new Vector3(0, velocity, 0) * Time.deltaTime);
        //    bird1.active = false;
        //}

        //float angle = 0f;
        //if(bird.transform.position.y<0)
        //{
        //    angle = Mathf.Lerp(0, -90, -bird.transform.position.y / jumpForce);
        //}
        //bird.transform.rotation = Quaternion.Euler(0, 0, angle);

    }
    
}
