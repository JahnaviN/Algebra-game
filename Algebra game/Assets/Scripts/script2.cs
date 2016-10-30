using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class script2 : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData)
    {
        Image img = transform.GetChild(0).GetComponent<Image>();
        img.sprite = script1.itemBeingDragged.transform.GetComponent<Image>().sprite;
        script1.itemBeingDragged.transform.position = script1.itemBeingDragged.transform.parent.position;

    }
}
