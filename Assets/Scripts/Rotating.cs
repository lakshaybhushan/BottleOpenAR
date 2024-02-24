using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotating : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    // Start is called before the first frame update

    bool ispressed = false;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if(ispressed)
        {
            player.transform.Rotate(0,0,1f);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}
