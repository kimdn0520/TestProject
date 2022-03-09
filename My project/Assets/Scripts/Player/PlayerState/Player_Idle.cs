using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Idle : State
{
    private Player _player;

    public Player_Idle(Player player)
    {
        _player = player;
    }

    void State.OnStart()
    {
        Debug.Log("Idle 상태 진입");
    }

    void State.FixedUpdate()
    {
        if (_player.h != 0 || _player.v != 0)
        {
            _player.SetState(new Player_Walk(_player));
        }
    }

    void State.Update()
    {

    }

    void State.OnEnd()
    {
        Debug.Log("Idle 상태 탈출");
    }
}
