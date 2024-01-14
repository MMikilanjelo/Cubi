using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaComponent : MonoBehaviour, IVisitable
{
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        Debug.Log("recived mana from visitor");
    }
}