using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Platform : MonoBehaviour , IPlatform 
{
    private float _jumpIncreasment = 10f;
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
    void OnTriggerExit2D(Collider2D _collider)
    {
        EventManager<EventTypes.PlatformEvents , float>
        .TriggerEvent(EventTypes.PlatformEvents.ExitWhitePlatform , _jumpIncreasment);
    }
    public void Interaction(Collider2D _collider)
    {
        EventManager<EventTypes.PlatformEvents , float>
        .TriggerEvent(EventTypes.PlatformEvents.JumpedOnWhitePlatform , _jumpIncreasment);
    }

}
