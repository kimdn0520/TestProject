using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeNode
{
    private List<Node> _children = new List<Node>();

    public void AddChild(Node node)
    {
        _children.Add(node);
    }

    public List<Node> GetChildren()
    {
        return _children;
    }
}
