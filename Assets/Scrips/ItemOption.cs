using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOption : MonoBehaviour
{
    [SerializeField] private Canvas itemMenu;
    // Start is called before the first frame update

    private void Awake()
    {
        itemMenu.gameObject.SetActive(false);
    }
    // Update is called once per frame

    public void ShowItemMenu()
    {
        itemMenu.gameObject.SetActive(true);
    }
    public void HideItemMenu()
    {
        itemMenu.gameObject.SetActive(false);
    }

}
