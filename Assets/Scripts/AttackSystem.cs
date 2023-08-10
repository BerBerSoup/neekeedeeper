using System.Threading;
using UnityEngine;



public class AttackSystem : MonoBehaviour
{

    [Header("攻擊")]
    public Animator atkani1;
    [Header("執行攻擊")]
    public string parAtk = "攻擊";

    private float timer;

    private void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            atkani1.SetBool(parAtk, true);
        }
        else
        {
            atkani1.SetBool(parAtk, false);
        }
    }
}
