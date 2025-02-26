using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    [SerializeField] private float roamingDistanceMax = 7f;
    [SerializeField] private float roamingDistanceMin = 3f;
    [SerializeField] private float roamingTimerMax = 2f;
    
    private NavMeshAgent navMeshAgent;
    private float roamingTime;
    private Vector3 roamPosition;
    private Vector3 startingPosition;
    
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
        navMeshAgent.updateUpAxis = false;
        startingPosition = transform.position;
    }
    
    private void Update()
    {
        roamingTime -= Time.deltaTime;
        if (roamingTime < 0 || (transform.position - roamPosition).sqrMagnitude < 0.5f)
        {
            Roaming();
            roamingTime = roamingTimerMax;
        }
    }
    
    private void Roaming()
    {
        roamPosition = GetRoamingPosition();
        ChangeFacingDirection(startingPosition, roamPosition);
        navMeshAgent.SetDestination(roamPosition);
    }
    
    private Vector3 GetRoamingPosition()
    {
        return startingPosition + (Random.insideUnitSphere * Random.Range(roamingDistanceMin, roamingDistanceMax));
    }
    
    private void ChangeFacingDirection(Vector3 sourcePosition, Vector3 targetPosition)
    {
        transform.rotation = sourcePosition.x < targetPosition.x ? Quaternion.Euler(0, -180, 0) : Quaternion.Euler(0, 0, 0);
    }
}