using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird3 : Bird1
{
    [SerializeField] private Image imageCoolDown;
    [SerializeField] private float cdTime = 5f;
    private bool isCoolDown = false;

    public override void Awake()
    {
        //inTimeSkill = timeSkill;
    }
    // Start is called before the first frame update
    public override void Update()
    {
        base.BirdMove();
        if (Option.GetBird()==3)
        {
            Slow();
        }
    }
    public void Slow()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isCoolDown = true;
        }
        if (isCoolDown && FlappyBird.birdActive == FlappyBird.SetActive.Alive)
        {
            Time.timeScale = 0.4f;

            imageCoolDown.fillAmount += 1 / cdTime * Time.deltaTime;
            if (imageCoolDown.fillAmount >= 1)
            {
                imageCoolDown.fillAmount = 0;

                Time.timeScale = 1f;
                isCoolDown = false;
            }
        }
    }
    //public void Slow()
    //{
    //    BirdMove();
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
            
    //    }
    //    if (Input.GetKeyUp(KeyCode.E))
    //    {
    //        Time.timeScale = 1f;
    //    }
    //}
}
