using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITrack : Node
{
    private AI _ai;

    public AITrack(AI ai)
    {
        _ai = ai;
    }

    public bool Invoke()
    {
        Vector2 trackNormalVec = (_ai.player.GetComponent<Transform>().position - _ai.GetComponent<Transform>().position).normalized;

        _ai.transform.Translate(trackNormalVec * _ai.speed * Time.deltaTime);

        return true;
    }
}
