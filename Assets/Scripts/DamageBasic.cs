using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("資料")]
    public DataBasic data;

    private float hp;

    private void Awake()
    {
        hp = data.hp;
    }

    public void Damage(float damage)
    {
        hp -= damage;

        if (hp <= 0) Dead();

        print("受傷");
    }

    private void Dead()
    {
        print("死亡");
    }
}
