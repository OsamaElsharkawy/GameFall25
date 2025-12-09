using UnityEngine;

[CreateAssetMenu(fileName ="New Enemy", menuName ="Enemies/Enemy")]
public class EnemyScriptableObjects : ScriptableObject
{
    public Color enemyColor;
    public float speed;
}
