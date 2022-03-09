using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface State
{
    // 상태가 시작할 때
    void OnStart();

    void FixedUpdate();

    void Update();

    // 상태를 탈출할 때
    void OnEnd();
}
