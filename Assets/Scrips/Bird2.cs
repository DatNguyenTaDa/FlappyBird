using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird2 : Bird1
{
    [SerializeField] private Image imageCoolDown;
    [SerializeField] private float cdTime = 1f;
    private bool isCoolDown = false;
    //[SerializeField] private float timeSkill = 1000;
    //private float timer = 0;
    //private float wallMaxTimne;
    // Start is called before the first frame update
    public override void Awake()
    {
        
    }
    public override void Update()
    {
        base.BirdMove();
        if(Option.GetBird()==2)
        {
            Dash();
        }
    }
    public void Dash()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isCoolDown = true;
        }
        if (isCoolDown && FlappyBird.birdActive == FlappyBird.SetActive.Alive)
        {
            Move.speed = 8;
            maxTime = 0.5f;
            isCollider = false;

            imageCoolDown.fillAmount += 1 / cdTime * Time.deltaTime;
            if (imageCoolDown.fillAmount >= 1)
            {
                imageCoolDown.fillAmount = 0;

                Move.speed = 2;
                maxTime = 2f;
                isCollider = true;

                isCoolDown = false;
            }


        }
    }
    //public virtual void Dash()
    //{
    //    BirdMove();
    //    if (Input.GetKeyDown(KeyCode.E))
    //    {
    //        Move.speed = 8;
    //        Bird1.maxTime = 0.5f;
    //        Bird1.isCollider = false;
    //    }
    //    if (Input.GetKeyUp(KeyCode.E))
    //    {
    //        Move.speed = 2;
    //        Bird1.maxTime = 2f;
    //        Bird1.isCollider = true;
    //    }
    //}
}
