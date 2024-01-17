using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BouderPlatform : MonoBehaviour , IPlatform
{
    public Transform _respawnPoint;



    public void OnTriggerEnter2D(Collider2D _otherCollider)
    {
        Interaction(_otherCollider);
    }
    public void Interaction(Collider2D _otherCollider)
    {
        if(_otherCollider.CompareTag("Player"))
        {
            var _deathPosition = this.transform.position;
            EventManager<EventTypes.PlayerEvents , Vector3>
            .TriggerEvent(EventTypes.PlayerEvents.PlayerDeath , _respawnPoint.transform.position);
        }
    }


}
