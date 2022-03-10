using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIIdle : Node
{
    private AI _ai;

    public AIIdle(AI ai)
    {
        _ai = ai;
    }

    public void OnStart()
    {
        _ai.currentNode = this;
        _ai.animator.Play("AI_Idle");  
    }

    public bool Invoke()
    {
        if (_ai.currentNode != this)
        {
            _ai.currentNode.OnEnd();

            OnStart();
        }

        return true;
    }

    public void OnEnd()
    {

    }
}
