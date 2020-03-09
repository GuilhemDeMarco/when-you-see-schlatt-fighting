using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_SchlattWalk : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    public float speed = 5f;
    private int leftOrRight;
    void Start()
    {
        //Spawn at a random position outside of the player box
        leftOrRight = (Random.Range(0, 2));
        if (leftOrRight == 0)
        {
            //left
            float randomPosX = Random.Range(-8, -18);
            float randomPoxY = Random.Range(10, -6);
            transform.position = new Vector2(randomPosX, randomPoxY);
        }
        else
        {
            //right
            float randomPosX = Random.Range(8, 18);
            float randomPoxY = Random.Range(10, -6);
            transform.position = new Vector2(randomPosX, randomPoxY);
            transform.GetChild(0).GetComponent<SpriteRenderer>().flipX = true;
        }
        
        player = GameObject.FindWithTag("Player");
        Quaternion rotation = Quaternion.LookRotation(player.transform.position - transform.position, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);
    }

    // Update is called once per frame
    void Update()
    {

        var schlatt = transform.GetChild(0).gameObject.transform;
        if(schlatt.localPosition.x <= 30)
        {
            if(leftOrRight == 0)
            {
                schlatt.localPosition = new Vector2(schlatt.localPosition.x + speed * Time.deltaTime, 0f);
            }
            else
            {
                schlatt.localPosition = new Vector2(schlatt.localPosition.x - speed * Time.deltaTime, 0f);
            }
            
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    
}
