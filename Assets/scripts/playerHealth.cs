using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health = health - damage;
        
    }
}
