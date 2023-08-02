using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("ª±®a«Ý¾÷").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.008f);
    }
}
