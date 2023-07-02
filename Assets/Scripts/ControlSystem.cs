using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header ("移動速度")]
    [Range (0,50)]
    public float moveSpeed = 10f;
    [Header("剛體")]
    public Rigidbody2D rig;


    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }

    private void Awake()
    {
        
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rig.velocity = new Vector2(h, v);
    }

}
