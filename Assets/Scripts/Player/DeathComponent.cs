using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeathComponent : MonoBehaviour
{
    TrailRenderer trailRenderer;
    void Awake()
    {
        EventManager<EventTypes.PlayerEvents , Vector3>.RegisterEvent(EventTypes.PlayerEvents.PlayerDeath , onPlayerDeath);

        trailRenderer = GetComponent<TrailRenderer>();
    }

   
    private void onPlayerDeath(Vector3 _respawnPoint)
    {
        trailRenderer.Clear();
    }
}
