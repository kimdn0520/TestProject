using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// IDLE, TRACK, ATTACK
/// </summary>
public class AI : MonoBehaviour
{
    public Transform transform;
    public Animator animator;

    Sequence root = new Sequence();         // 시퀀스로 루트 노드를 만들어준다. 루트 노드는 하나의 셀렉터 혹은 시퀀스를 갖는다.

    Selector selector1 = new Selector();    // 루트 다음은 Selector가 적당할 것 같다.

    Sequence sequence1 = new Sequence();
    Sequence sequence2 = new Sequence();

    AICanAttack aiCanAttack; 
    AIAttack aiAttack;
    AICanTrack aiCanTrack; 
    AITrack aiTrack;
    AIIdle aiIdle;

    public GameObject player;
    public float speed;
    public float atkCoolTime;
    
    void Awake()
    {
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        speed = 5.0f;
        atkCoolTime = 2.0f;

        aiCanAttack = new AICanAttack(this);
        aiAttack = new AIAttack(this);
        aiCanTrack = new AICanTrack(this);
        aiTrack = new AITrack(this);
        aiIdle = new AIIdle(this);

        root.AddChild(selector1);           // 루트 child로 selector 추가

        selector1.AddChild(sequence1);
        selector1.AddChild(sequence2);

        sequence1.AddChild(aiCanAttack);
        sequence1.AddChild(aiAttack);
        selector1.AddChild(aiIdle);

        sequence2.AddChild(aiCanTrack);
        sequence2.AddChild(aiTrack);
    }

    private void Update()
    {
        root.Invoke();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player = collision.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player = null;
        }
    }
}
