using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text highScore;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        score.text ="Score: " + Bird1.instance.GetScore().ToString();
        highScore.text = "Your High Score: " + Bird1.instance.GetHighScore().ToString();
    }
}
