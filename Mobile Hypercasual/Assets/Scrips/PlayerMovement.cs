using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Vector3 targetPos;
    private Rigidbody playerRb;
    public float moveSpeed = 20;

    public float longMoveDistance = 5f;


    
    // Start is called before the first frame update
    void Start()
    {   
        playerRb = GetComponent<Rigidbody>();

        
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =  Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection * longMoveDistance;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
        
    }

}
