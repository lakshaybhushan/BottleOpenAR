using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurnNTwist : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    // Start is called before the first frame update

    bool ispressed = false;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        if(ispressed)
        {
            player.transform.Translate(0,0.05f,0);
            player.transform.Rotate(0,-4f,0);
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
