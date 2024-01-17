using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlatform : MonoBehaviour , IPlatform
{
    void OnTriggerEnter2D(Collider2D _collider)
    {
        Interaction(_collider);
    } 
    public void Interaction(Collider2D _collider)
    {
        Debug.Log("Interack with Blue Platform");
    } 
}
