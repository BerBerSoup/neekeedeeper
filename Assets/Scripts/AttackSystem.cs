using UnityEngine;



public class AttackSystem : MonoBehaviour
{

    [Header("����")]
    public Animation atkani1;
    [Header("�������")]
    public string parAtk = "����";

    private void Attack() 
    {
        atkani1.SetBool(parAtk);
        if (Input.GetKeyDown(KeyCode.J))
        {
            print("jjj");
        }
    }
}
