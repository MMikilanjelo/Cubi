using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Testing : MonoBehaviour
{  
    public PawerUp _powerUp;
    CircleCollider2D _col;
    public void Awake()
    {
        _col = GetComponent<CircleCollider2D>();
        Debug.Log(_col);
        EventManager<EventTypes.PlayerEvents,int>.RegisterEvent(EventTypes.PlayerEvents.ScoreCollected , UpdateScore);
        
    }
    public void UpdateScore(int score)
    {
        Debug.Log($"Recived Score {score}");
    }
    public void OnTriggerEnter2D(Collider2D _otherCollider)
    {
        var _visitable = _otherCollider.GetComponent<IVisitable>();
        if(_visitable != null)
        {
            _visitable.Accept(_powerUp);
            Destroy(gameObject);
        }
    }
}
