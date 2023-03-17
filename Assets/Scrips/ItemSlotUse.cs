

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotUse : MonoBehaviour, IDropHandler {
    [SerializeField] private RectTransform item1;
    [SerializeField] private RectTransform item2;
    private void Start()
    {
        if (PlayerPrefs.GetInt("Item2") == 1)
        {
            item2.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
        if (PlayerPrefs.GetInt("Item1") == 1)
        {
            item1.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag.name == "Item2") {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            PlayerPrefs.SetInt("Item2", 1);
        }
        if (eventData.pointerDrag.name == "Item1")
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            PlayerPrefs.SetInt("Item1", 1);
        }
    }

}
