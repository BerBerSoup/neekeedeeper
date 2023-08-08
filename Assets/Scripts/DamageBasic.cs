using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("���")]
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

        print("����");
    }

    private void Dead()
    {
        print("���`");
    }
}
