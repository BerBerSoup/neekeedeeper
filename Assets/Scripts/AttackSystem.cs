using UnityEngine;



public class AttackSystem : MonoBehaviour
{

    [Header("§ðÀ»")]
    public Animation atkani1;
    [Header("°õ¦æ§ðÀ»")]
    public string parAtk = "§ðÀ»";

    private void Attack() 
    {
        atkani1.SetBool(parAtk);
        if (Input.GetKeyDown(KeyCode.J))
        {
            print("jjj");
        }
    }
}
