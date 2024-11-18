using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform[] waypoints; // Pontos de patrulha
    public float patrolSpeed = 2.0f; // Velocidade de patrulha
    private int currentWaypoint = 0; // Índice do waypoint atual

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        //Verifica se não há Waypoints. Se não há. a função termina (e o inimigo não se move);
        if (waypoints.Length == 0) return;

        //Obtém o waypoint atual
        Transform target = waypoints[currentWaypoint];
        //"Target.position - transform.position" calcula a direção entre a posição atual do inimigo e o próximop waypoint. Normalized faz com que a velocidade não seja alterada, apenas a posição.
        Vector3 direction = (target.position - transform.position).normalized;

        //Move em direção ao Waypoint
        /*
        Direction é a direção que calculamos;
        patrolSpeed é a velocidade do inimigo;
        Time.deltaTime é o tempo entre os frames, garantindoum movimento
        */
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.position += direction * patrolSpeed * Time.deltaTime;
        transform.position += direction * patrolSpeed * Time.deltaTime;
        
        /*
        Vector3.Distance calcula a distância entre o inimigo (transform.position) e o waypoint (target.position). Aquele < 0.5f verifica se a distância é próxima suficiente (pois não precisa ser igual).
        */
        //Verifica se chegou ao próximo Waypoint
        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length; // Avança para o próximo waypoint
        }
    }
}
