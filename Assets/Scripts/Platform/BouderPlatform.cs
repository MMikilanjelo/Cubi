using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BouderPlatform : MonoBehaviour
{
    public Transform _respawnPoint;
    public void OnTriggerEnter2D(Collider2D _otherCollider)
    {
        var _deathPosition = this.transform.position;
        if(_otherCollider.CompareTag("Player"))
        {
            EventManager<EventTypes.PlayerEvents , Vector3>.TriggerEvent(EventTypes.PlayerEvents.PlayerDeath , _respawnPoint.transform.position);
        }
    }
}
