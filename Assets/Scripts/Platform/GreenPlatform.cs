using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatform : MonoBehaviour, IPlatform
{

    void OnTriggerEnter2D(Collider2D _collider)
    {
        Interaction(_collider);
    } 
    public void Interaction(Collider2D collider2D)
    {
        Debug.Log("Interack with green platform");
    } 
}
