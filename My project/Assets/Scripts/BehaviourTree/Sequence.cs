using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : CompositeNode, Node
{
    public bool Invoke()
    {
        foreach (var node in GetChildren())
        {
            if (!node.Invoke())
            {
                return false;
            }
        }

        return true;
    }
}
