using UnityEngine;
public class Enemy : MonoBehaviour
{
    public virtual void DealDamage()
    {
        Player.player.health -= 0.0f;
    }
    public virtual void SlowPlayer()
    {
        Player.player.speed -= 0.0f;
    }
}

public class Juggernaut : Enemy
{
    public override void DealDamage()
    {
        Player.player.health -= 10.0f;
        SlowPlayer();
    }
    public override void SlowPlayer()
    {
        Player.player.speed -= -4.0f;
    }
    private void Update()
    {
        if(Player.inRadius)
        {
            DealDamage();
        }
    }
}