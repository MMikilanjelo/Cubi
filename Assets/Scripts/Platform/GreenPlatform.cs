using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatform : MonoBehaviour, IPlatform
{
    private float _speedIncreasment = 10f;
    void OnTriggerEnter2D(Collider2D _collider)
    {
        Interaction(_collider);
    }   
    void OnTriggerExit2D(Collider2D _collider)
    {
        EventManager<EventTypes.PlatformEvents , float>
        .TriggerEvent(EventTypes.PlatformEvents.ExitGreenPlatform , _speedIncreasment);
    }
    public void Interaction(Collider2D collider2D)
    {
        EventManager<EventTypes.PlatformEvents , float>
        .TriggerEvent(EventTypes.PlatformEvents.JumpedOnGreenPlatform , _speedIncreasment);
    } 
}
