

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;

public class ItemSlotDontUse2 : MonoBehaviour, IDropHandler
{
    [SerializeField] private RectTransform item1;
    [SerializeField] private RectTransform item2;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Item2") == 2)
        {
            item2.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
        if (PlayerPrefs.GetInt("Item1") == 2)
        {
            item1.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag.name == "Item2")
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            PlayerPrefs.SetInt("Item2", 2);
        }
        if (eventData.pointerDrag.name == "Item1")
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            PlayerPrefs.SetInt("Item1", 2);
        }
    }

}
