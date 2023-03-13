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
    
    private int activeNum;
    private int birdStyle;


    
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

    }
    
}
