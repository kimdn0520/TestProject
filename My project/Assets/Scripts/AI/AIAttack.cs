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

    public bool Invoke()
    {
        _ai.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);

        return true;
    }
}
