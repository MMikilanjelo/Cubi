using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour , IPlatform 
{
    public void Awake()
    {
        
    }
    public void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D _collider)
    {
        Interaction(_collider);
    }   

    public void Interaction(Collider2D _collider)
    {
        EventManager<EventTypes.PlatformEvents,float>
        .TriggerEvent(EventTypes.PlatformEvents.JumpedOnWhitePlatform , 10);
    }
    
}
