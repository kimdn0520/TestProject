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

    public bool Invoke()
    {
        _ai.animator.Play("AI_Idle");   // 임시 

        return true;
    }
}
