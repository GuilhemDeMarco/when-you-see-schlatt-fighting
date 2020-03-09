using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{
    public playerHealth playerHealth;
    public float damage = 10f;
    // Start is called before the first frame update
    private void Start()
    {
        playerHealth = FindObjectOfType<playerHealth>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if(collision.name == "playerHeart")
        {
            playerHealth.TakeDamage(damage);
            Debug.Log(damage);
            Destroy(transform.parent.gameObject);
        }
        
    }
    
}
