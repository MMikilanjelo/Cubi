using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publisher : MonoBehaviour
{
    void Start()
    {
            
    }
    void Update()
    {
        EventManager<EventType , int>.TriggerEvent(EventType.ScoreCollected , 12);   
    }

}
