using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ComponentHandler : MonoBehaviour , IVisitable
{
    List<IVisitable> _visitableComponents = new List<IVisitable>();

    public void Accept(IVisitor visitor)
    {
        foreach(var _visitable in _visitableComponents)
        {
            _visitable.Accept(visitor);
        }
    }

    void Start()
    {
        _visitableComponents.Add(gameObject.GetOrAddComponent<HealthComponent>());
        _visitableComponents.Add(gameObject.GetOrAddComponent<ManaComponent>());
    }

}
