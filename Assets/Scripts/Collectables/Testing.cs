using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Testing : MonoBehaviour
{  
    
    public void Awake()
    {
        EventManager<EventType,int>.RegisterEvent(EventType.ScoreCollected , UpdateScore);
    }
    public void UpdateScore(int score)
    {
        Debug.Log($"Recived Score {score}");
    }
}
