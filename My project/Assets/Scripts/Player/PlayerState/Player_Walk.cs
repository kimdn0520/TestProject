using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Walk : State
{
    private Player _player;

    public Player_Walk(Player player)
    {
        _player = player;
    }

    void State.OnStart()
    {
        // Debug.Log("Walk 상태 진입");
    }

    void State.FixedUpdate()
    {
        if (_player.h == 0 && _player.v == 0)
        {
            _player.SetState(new Player_Idle(_player));
        }

        _player.transform.Translate(_player.moveDir.normalized * _player.speed * Time.deltaTime);
    }

    void State.Update()
    {

    }

    void State.OnEnd()
    {
        // Debug.Log("Walk 상태 탈출");
    }
}
