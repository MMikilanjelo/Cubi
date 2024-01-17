using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] GameObject _playerGameObject;
    public float _respawnDuration  = 0.2f;
    void Awake()
    {
        EventManager<EventTypes.PlayerEvents , Vector3>.RegisterEvent(EventTypes.PlayerEvents.PlayerDeath , onPlayerDeath);
    }

   
    private void onPlayerDeath(Vector3 _respawnPoint)
    {
        StartCoroutine(Respaw(_respawnDuration , _respawnPoint));
       
    }
    IEnumerator Respaw(float _duration  ,Vector3 _respawnPoint )
    {   
        _playerGameObject.SetActive(false);
        _playerGameObject.transform.position  = _respawnPoint;
        yield return new WaitForSeconds(_duration);
        _playerGameObject.SetActive(true);
    }
}
