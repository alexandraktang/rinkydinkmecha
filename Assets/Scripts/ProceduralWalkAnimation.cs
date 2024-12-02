using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralWalkAnimation : MonoBehaviour
{
    [SerializeField] GameObject legIK;
    [SerializeField] GameObject otherFootIK;
    Vector3 startingPosition;
    Vector3 newPosition;
    float walkSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        startingPosition = legIK.transform.position;
        if (Input.GetKey(KeyCode.W)) {


            
            newPosition = new Vector3(walkSpeed * Time.deltaTime, 0, 0); // moving along x
            transform.position -= newPosition; // update position of foot IK along x

            Debug.Log("startingPos: " + startingPosition.x);
            Debug.Log("newPos: " + newPosition.x);

            if (Mathf.Abs(startingPosition.x - newPosition.x) > .5f) {
                legIK.transform.position = newPosition;
            }
            
        }
        */
    }
}
