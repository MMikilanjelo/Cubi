using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StatsController : MonoBehaviour
{
    private ScriptableStats _startingMovmentStats;
   
    public void Awake()
    {
        _startingMovmentStats = GetComponent<PlayerController>()._movmentStas;
        EventManager<EventTypes.PlatformEvents,float>
        .RegisterEvent(EventTypes.PlatformEvents.JumpedOnWhitePlatform , IncreaseJumpPower);

        EventManager<EventTypes.PlatformEvents,float>
        .RegisterEvent(EventTypes.PlatformEvents.ExitWhitePlatform , DecreaseJumpPower);

        EventManager<EventTypes.PlatformEvents,float>
        .RegisterEvent(EventTypes.PlatformEvents.JumpedOnGreenPlatform , IncreaseSpeed);

        EventManager<EventTypes.PlatformEvents,float>
        .RegisterEvent(EventTypes.PlatformEvents.ExitGreenPlatform , DecreaseSpeed);

    }
    
    #region Green Platform
    public void IncreaseSpeed(float amount)
    {
        _startingMovmentStats.MaxSpeed += amount;
    }
    public void DecreaseSpeed(float amount)
    {
       _startingMovmentStats.MaxSpeed -= amount; 
    }
    #endregion 
    
    
    #region White Platform
    public void IncreaseJumpPower(float amount)
    {
        _startingMovmentStats.JumpPower += amount;
    }
    public void DecreaseJumpPower(float amount)
    {
        _startingMovmentStats.JumpPower -= amount;
    }
    #endregion
}
