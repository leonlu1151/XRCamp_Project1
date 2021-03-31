using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
using Random = UnityEngine.Random;

public class AI_walking : MonoBehaviour
{

    Animator anim;
    Vector3 moveToPos;
    bool movementActive;
    float dist;
    float lastDist;
    int arrived=0;
    float ti = 0;
    float se = 5;
    public NavMeshAgent agent;    //宣告NavMeshAgent
    public GameObject target_obj;    //目標物件
    public GameObject sit_pos;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        movementActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            moveToPos = target_obj.transform.position;
            dist = Vector3.Distance(agent.transform.position, moveToPos);
            agent.SetDestination(moveToPos);
            anim.SetInteger("condition", 1);
            
            movementActive = true;
        }

        if (movementActive)
        {
            agent.speed = Random.Range(1.0f, 3.5f);
            dist = Vector3.Distance(agent.transform.position, moveToPos);
            if (target_obj.transform.position.x == agent.transform.position.x && target_obj.transform.position.z == agent.transform.position.z)
            {
                anim.SetInteger("condition", 0);
                agent.enabled = false;
                movementActive = false;
                arrived = 1;
            }
            lastDist = dist;

        }
        if (arrived == 1)
        {
            if (ti <= se)
            {
                ti += Time.deltaTime;
            }
            else
            {
                anim.SetInteger("condition", 3);
                transform.position = sit_pos.transform.position;

                //mom
                transform.localEulerAngles = new Vector3(0, 98.13f, 0);
            }
        }




    }
}

