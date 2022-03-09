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

    public bool Invoke()
    {
        if(_ai.player != null)
        {
            float dist = (_ai.player.GetComponent<Transform>().position - _ai.GetComponent<Transform>().position).magnitude;

            if(dist <= 1.0f)
            {
                return true;
            }
        }

        _ai.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);

        return false;
    }
}
