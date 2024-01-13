using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Testing : MonoBehaviour
{  
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
        Debug.Log(_otherCollider);
        Destroy(gameObject);   
    }
}
