using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisitor
{
    void Visit(HealthComponent healthComponent);
    void Visit (ManaComponent manaComponent);
}

