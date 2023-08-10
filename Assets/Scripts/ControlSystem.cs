using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header ("移動速度")]
    [Range (0,100)]
    public float moveSpeed = 10f;
    [Header("剛體")]
    public Rigidbody2D rig;
    [Header("動畫控制器")]
    public Animator ani;
    [Header("跑步參數")]
    public string parRun = "跑起來";


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
        rig.velocity = new Vector2(h, v) * moveSpeed;

        ani.SetBool(parRun, h != 0 || v != 0);

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            print("aaa");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}
