using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AgentMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform fixedTarget;
    private NavMeshAgent navMeshAgent;
    private Animator characterAnimator;
    private bool isAlreadySet = false;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        characterAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < 35f)
        {
            navMeshAgent.SetDestination(target.position);
            if (!isAlreadySet)
            {
                characterAnimator.SetBool("isInRange", true);
                isAlreadySet = true;
            }
        }
        else
        {
            navMeshAgent.SetDestination(fixedTarget.position);
            float distanceToFixedTarget = Vector3.Distance(transform.position, fixedTarget.position);
            if (distanceToFixedTarget < 3f)
            {
                characterAnimator.SetBool("isInRange", false);
                navMeshAgent.SetDestination(transform.position);
            }
            else
            {
                if (!isAlreadySet)
                {
                    characterAnimator.SetBool("isInRange", true);
                }
            }
        }
    }
}
