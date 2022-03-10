using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttack : Node
{
    private AI _ai;

    public AIAttack(AI ai)
    {
        _ai = ai;
    }

    public void OnStart()
    {
        _ai.currentNode = this;
        // _ai.animator.Play("AI_Attack");
    }

    public bool Invoke()
    {
        if (_ai.currentNode != this)
        {
            _ai.currentNode.OnEnd();

            OnStart();
        }

        if (!_ai.isAttack && _ai.curAtkTimer >= _ai.atkCoolTime)
        {
            _ai.animator.Play("AI_Attack", -1, 0f);
            _ai.curAtkTimer = 0;
        }
        else if(!_ai.isAttack && _ai.curAtkTimer < _ai.atkCoolTime)
        {
            _ai.animator.Play("AI_Idle", -1, 0f);
        }

        return true;
    }

    public void OnEnd()
    {

    }
}
