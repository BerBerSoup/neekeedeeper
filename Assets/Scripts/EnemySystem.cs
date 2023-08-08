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

        if (transform.position.x > player.position.x) transform.eulerAngles = new Vector3(0, 180, 0);
        else transform.eulerAngles = new Vector3(0, 0, 0);     
    }
}
