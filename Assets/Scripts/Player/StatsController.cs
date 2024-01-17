using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsController : MonoBehaviour
{
    private PlayerController _playerController;
    private ScriptableStats _scriptableStats;
    public void Awake()
    {
        _scriptableStats = GetComponent<PlayerController>()._movmentStas;
        EventManager<EventTypes.PlatformEvents,float>
        .RegisterEvent(EventTypes.PlatformEvents.JumpedOnWhitePlatform , IncreaseMovmentSpeed);
    }
    public void IncreaseMovmentSpeed(float amount)
    {
        // _scriptableStats.JumpPower += amount;
        // Debug.Log(amount);
    }
}
