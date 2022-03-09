using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private State _currentState;

    public Transform transform;
    public Rigidbody2D rigidbody2D;
    public Vector2 moveDir;
    public float h;
    public float v;
    public float speed;

    private void Awake()
    {
        transform = GetComponent<Transform>();
        rigidbody2D = GetComponent<Rigidbody2D>();

        h = 0;
        v = 0;
        speed = 10.0f;
        
        SetState(new Player_Idle(this));
    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        moveDir = new Vector2(h, v);

        _currentState.FixedUpdate();
    }

    private void Update()
    {
        _currentState.Update();
    }

    public void SetState(State nextState)
    {
        if (_currentState != null)
        {
            // 기존의 상태가 존재했다면 OnEnd() 호출
            _currentState.OnEnd();
        }

        // 다음 State 시작
        _currentState = nextState;
        _currentState.OnStart();
    }
}
