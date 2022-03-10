using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICanAttack : Node
{
    private AI _ai;

    public AICanAttack(AI ai)
    {
        _ai = ai;
    }

    public void OnStart()
    {

    }

    public bool Invoke()
    {
        // 공격 중이라면 true
        if (_ai.isAttack)
            return true;

        if(_ai.player != null)
        {
            float dist = (_ai.player.GetComponent<Transform>().position - _ai.GetComponent<Transform>().position).magnitude;

            if(dist <= 1.0f)
            {
                return true;
            }
        }

        _ai.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);

        return false;
    }

    public void OnEnd()
    {

    }
}
