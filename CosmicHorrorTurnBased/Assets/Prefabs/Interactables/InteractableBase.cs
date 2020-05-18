using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBase : MonoBehaviour
{
    public InteractableBase[] _prefabsToActivate;
    public virtual void Activate()
    {
        foreach(var entry in _prefabsToActivate)
        {
            entry.Activate();
        }
    }
}
