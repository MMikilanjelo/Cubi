using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour, IVisitable
{
    public void Accept(IVisitor visitor)
    {  
        visitor.Visit(this);
        Debug.Log("recived health from visitor");
    }
}
