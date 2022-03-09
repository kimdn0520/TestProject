using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICanTrack : Node
{
    private AI _ai;

    public AICanTrack(AI ai)
    {
        _ai = ai;
    }

    public bool Invoke()
    {
        if (_ai.player != null)
        {
            return true;
        }

        return false;
    }
}
