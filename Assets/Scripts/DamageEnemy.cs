using UnityEngine;

public class DamageEnemy : DamageBasic
{
    private void OnCollisionEnter(Collision collision)
    {
        Damage(30);
    }
}
