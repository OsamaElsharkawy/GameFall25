using UnityEngine;
using UnityEngine.AI;

public class EnemyType : MonoBehaviour
{
    public EnemyScriptableObjects enemySO;
    public Material enemyMaterial;

    public NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        enemyMaterial.color = enemySO.enemyColor;

        agent.speed = enemySO.speed;
    }
}
