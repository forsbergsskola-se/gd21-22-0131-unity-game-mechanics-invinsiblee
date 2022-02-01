using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    [SerializeField] private CommandContainer commanContainer;
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        //To get targets vector position
        var directionToPlayer = playerTransform.position - transform.position;
        directionToPlayer.Normalize();
        var horizontalDiretion = directionToPlayer.x;
        commanContainer.walkCommand = horizontalDiretion;
    }
}
