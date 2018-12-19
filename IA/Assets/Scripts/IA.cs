using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{

    public enum States { Idle, Walk, Attack };
    public States miestado = States.Idle;
    public GameObject Player;
    private Animator anim;
    private Rigidbody myrigi;

    public Transform target;
    public float speed;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        myrigi = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (miestado)
        {
            case States.Idle:
                Idle();
                break;
            case States.Walk:
                Walk();
                break;
            case States.Attack:
                Attack();
                break;
            default:
                print("Incorrect State");
                break;
        }
    }

    void Idle()

    {
        anim.Play("Idle");

        if (Vector3.Distance(transform.position, Player.transform.position) > 1 && Vector3.Distance(transform.position, Player.transform.position) < 8)
        {
            miestado = States.Walk;
        }

    }


    void Walk()
    {
        anim.Play("Walk");

        if (Vector3.Distance(transform.position, Player.transform.position) > 8)
        {
            miestado = States.Idle;
        }

        if (Vector3.Distance(transform.position, Player.transform.position) < 2)
        {
            miestado = States.Attack;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);



    }

    void Attack()
    {
        anim.Play("Attack");

        if (Vector3.Distance(transform.position, Player.transform.position) > 2)
        {
            miestado = States.Walk;
        }

        if (Vector3.Distance(transform.position, Player.transform.position) > 8)
        {
            miestado = States.Idle;
        }



    }
}
