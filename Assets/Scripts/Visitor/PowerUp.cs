using UnityEngine;

[CreateAssetMenu(fileName = "PawerUp" , menuName = "PawerUp")]
public class PawerUp : ScriptableObject, IVisitor
{
    public void Visit(HealthComponent healthComponent)
    {
        Debug.Log("visited health component");
    }

    public void Visit(ManaComponent manaComponent)
    {
        Debug.Log("visit a mana compoent");
    }
}