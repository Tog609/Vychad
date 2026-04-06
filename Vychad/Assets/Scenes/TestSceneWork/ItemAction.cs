using UnityEngine;

public abstract class ItemAction : ScriptableObject
{
    public abstract void Use(GameObject user);
}
