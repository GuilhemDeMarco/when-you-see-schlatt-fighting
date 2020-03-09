using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarController : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform bar;
    public playerHealth playerHealth;
    void Start()
    {
        bar = this.transform.GetChild(1).gameObject.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentHealth = playerHealth.health;
        SetHealthSize(currentHealth/100);
    }
    void SetHealthSize(float newSize)
    {
        bar.localScale = new Vector3(Mathf.Clamp(newSize,0f,1f), 1f);
    }
}
