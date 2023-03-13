using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Image backGround;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(FlappyBird.birdActive == FlappyBird.SetActive.Dead)
        {
            return;
        }
        Material mt = backGround.material;
        Vector2 offset = mt.mainTextureOffset;
        offset.x += Time.deltaTime * speed;
        mt.mainTextureOffset = offset;
        //transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
