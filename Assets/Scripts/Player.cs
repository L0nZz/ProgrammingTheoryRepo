using UnityEngine;
public class Player : MonoBehaviour
{
public static Player player;
public static bool inRadius;
private float fixedHealth;
public float health
    {
        get { return fixedHealth; }
        set
    {
        if (value > 0.0f)
        {
            Debug.LogError("Enemies can't increase the player's health");
        }

        else
            {
                fixedHealth = value;
            }
        }
    }
private float fixedSpeed;
public float speed
    {
        get { return fixedSpeed; }
        set
        {
            if (value > 0.0f)
            {
                Debug.LogError("Enemies can't increase the player's speed");
            }   

            else
            {
                fixedSpeed = value;
            }
        }
    }
}