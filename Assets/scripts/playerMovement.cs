using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float posY = transform.position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position = new Vector2(posX,posY);
    }
}
