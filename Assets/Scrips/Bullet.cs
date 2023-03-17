using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speedPullet;
    //[SerializeField] private GameObject[] targets;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speedPullet);
        //transform.position += new Vector3(1,0,0) * Time.deltaTime * speedPullet;
        if (transform.position.x > Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x ||
            transform.position.x < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x)
        {
            transform.gameObject.SetActive(false);
        }
        if (Mathf.Round(transform.position.x) == Mathf.Round(Bird1.instance.targets[Bird1.instance.temp].transform.position.x))
        {
            if(transform.position.y <= Bird1.instance.targets[Bird1.instance.temp].transform.position.y + 0.5f &&
                transform.position.y >= Bird1.instance.targets[Bird1.instance.temp].transform.position.y - 0.5f)
            {
                {
                    Bird1.instance.targets[Bird1.instance.temp].SetActive(false);
                }
                
            }
        }
        if ((Mathf.Round(transform.position.x) == Mathf.Round(Bird1.instance.wall[Bird1.instance.temp].transform.position.x) ||
            Mathf.Round(transform.position.x) == Mathf.Round(Bird1.instance.wall[Bird1.instance.temp].transform.position.x)) &&
            ((transform.position.y >= Bird1.instance.wall[Bird1.instance.temp].transform.position.y + 1.2f && transform.position.y < 5) ||
            (transform.position.y <= Bird1.instance.wall[Bird1.instance.temp].transform.position.y - 1.2f && transform.position.y > -5)))
        {
            Debug.Log("quay xe");
            transform.rotation = Quaternion.Euler(0,0, 180);
        }


    }
}
