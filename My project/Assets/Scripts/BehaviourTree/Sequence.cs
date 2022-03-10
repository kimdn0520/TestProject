using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : CompositeNode, Node
{
    public void OnStart() { }

    public bool Invoke()
    {
        foreach (var node in GetChildren())
        {
            // 하나라도 false가 나오면 false
            if (!node.Invoke())
            {
                return false;
            }
        }

        return true;
    }

    public void OnEnd() { }
}
