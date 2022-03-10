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

    public void OnStart()
    {
        _ai.currentNode = this;
        _ai.animator.Play("AI_Walk");
    }


    public bool Invoke()
    {
        if(_ai.currentNode != this)
        {
            _ai.currentNode.OnEnd();
            
            OnStart();
        }

        Vector2 trackNormalVec = (_ai.player.transform.position - _ai.transform.position).normalized;

        // 이것도 일단 임시
        if (trackNormalVec.x < 0)
            _ai.GetComponent<SpriteRenderer>().flipX = true;
        else
            _ai.GetComponent<SpriteRenderer>().flipX = false;

        _ai.transform.Translate(trackNormalVec * _ai.speed * Time.deltaTime);

        return true;
    }

    public void OnEnd()
    {

    }
}
