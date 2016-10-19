using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class script2 : MonoBehaviour, IDropHandler
{

    public GameObject item
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
        throw new NotImplementedException();
    }
}
