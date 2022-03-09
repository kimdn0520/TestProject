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
        _ai.animator.Play("AI_Walk");       // 다른데로 바꿔보장

        Vector2 trackNormalVec = (_ai.player.GetComponent<Transform>().position - _ai.GetComponent<Transform>().position).normalized;

        // 이것도 일단 임시
        if (trackNormalVec.x < 0)
            _ai.GetComponent<SpriteRenderer>().flipX = true;
        else
            _ai.GetComponent<SpriteRenderer>().flipX = false;

        _ai.transform.Translate(trackNormalVec * _ai.speed * Time.deltaTime);

        return true;
    }
}
