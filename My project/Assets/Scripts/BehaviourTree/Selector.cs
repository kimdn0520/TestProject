using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : CompositeNode, Node
{
    public void OnStart() {}

    public bool Invoke()
    {
        foreach (var node in GetChildren())
        {
            if (node.Invoke())
            {
                return true;
            }
        }

        return false;
    }

    public void OnEnd() {}
}
