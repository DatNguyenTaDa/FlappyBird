using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundTheme : MonoBehaviour
{
    [SerializeField] private Button turnOffTheme;
    [SerializeField] private Button turnOnTheme;
    [SerializeField] private AudioSource theme;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Awake()
    {
        theme.Play();
        if (Option.GetIsTurnOn() == 1)
        {
            theme.mute = true;
        }
    }
    void Update()
    {
        if(Option.GetIsTurnOn() == 2 || Option.GetIsTurnOn() == 0)
        {
            turnOffTheme.gameObject.SetActive(true);
            turnOnTheme.gameObject.SetActive(false);
            theme.mute = false;
        }
        else
        {
            turnOffTheme.gameObject.SetActive(false);
            turnOnTheme.gameObject.SetActive(true);
            theme.mute = true;
        }
    }
}
