using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiptVer : MonoBehaviour
{
    bool isFingerDown;

    private Vector2 startPos;
    private int swipeDistance = 20;
    public GameObject player;


    public PlayerMovement playerMovement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (!isFingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                startPos = Input.touches[0].position;
                isFingerDown = true;
            }

            if (isFingerDown)
            {
                if (Input.touches[0].position.y >= startPos.y + swipeDistance)
                {
                    isFingerDown = false;  
                    Debug.Log("Swipe Up");
                }
                
                if (Input.touches[0].position.y <= startPos.y - swipeDistance)
                {
                    isFingerDown = false;
                    Debug.Log("Swipe Down");
                }
              
                
                if (Input.touches[0].position.x >= startPos.x + swipeDistance)
                {
                    isFingerDown = false;
                    playerMovement.Move(Vector3.right);
                    Debug.Log("Swipe Right");
                }
                
                if (Input.touches[0].position.x <= startPos.x - swipeDistance)
                {
                    isFingerDown = false;
                    playerMovement.Move(Vector3.left);
                    Debug.Log("Swipe Left");
                }
                
            }
            if (isFingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
            {
                isFingerDown = false;
            }
    }
}
