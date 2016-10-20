using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class script2 : MonoBehaviour, IDropHandler
{
    /*public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            // Transform prevParent = script1.itemBeingDragged.transform.parent;
            script1.itemBeingDragged.transform.SetParent(transform);
            script1.itemBeingDragged.transform.position = transform.position;
        }
    }*/


    public void OnDrop(PointerEventData eventData)
    {
        /*if (!item)
        {
            Debug.Log(item.ToString());
            item = script1.itemBeingDragged.transform.GetComponent<Image>().sprite;
            //script1.itemBeingDragged.transform.SetParent(transform);
            //script1.itemBeingDragged.transform.position = transform.position;
        }*/

        Image img = transform.GetChild(0).GetComponent<Image>();
        img.sprite = script1.itemBeingDragged.transform.GetComponent<Image>().sprite;
        script1.itemBeingDragged.transform.position = script1.itemBeingDragged.transform.parent.position;

    }
}
