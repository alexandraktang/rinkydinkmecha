using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // Walking Variables
    [SerializeField] GameObject mech;
    Vector3 newPosition;
    float walkSpeed = 2f;
    [SerializeField] Animator mechAnim;

    // Hip Rotation
    [SerializeField] GameObject hips;
    float hipRotationSpeed = 30f;
    

    // View Rotation Variables
    [SerializeField] GameObject upperBody;
    float viewRotationSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // View Rotation
        if (Input.GetKey(KeyCode.LeftArrow)) {
            upperBody.transform.Rotate(0, 0, -Time.deltaTime * viewRotationSpeed);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            upperBody.transform.Rotate(0, 0, Time.deltaTime * viewRotationSpeed);
        }
        else if (Input.GetKey(KeyCode.UpArrow)) {
            upperBody.transform.Rotate(0, Time.deltaTime * viewRotationSpeed, 0);
        }
        else if(Input.GetKey(KeyCode.DownArrow)) {
            upperBody.transform.Rotate(0, -Time.deltaTime * viewRotationSpeed, 0);
        }

        // Movement
        if (Input.GetKey(KeyCode.W)) {
            // Camera movement animation
            mechAnim.SetBool("isWalking", true);

            float spd = Time.deltaTime * walkSpeed;

            newPosition = hips.transform.right * spd;
            mech.transform.position -= newPosition;
        }
        else if (Input.GetKey(KeyCode.S)) {
            // Camera movement animation
            mechAnim.SetBool("isWalking", true);

            float spd = Time.deltaTime * walkSpeed;

            newPosition = hips.transform.right * spd;
            mech.transform.position += newPosition;
        }
        else {
            mechAnim.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.A)) {
            hips.transform.Rotate(0, 0, -Time.deltaTime * hipRotationSpeed);
        }
        else if (Input.GetKey(KeyCode.D)) {
            hips.transform.Rotate(0, 0, Time.deltaTime * hipRotationSpeed);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            StartSwingLeftAnimation();
        }
        else if (Input.GetKeyDown(KeyCode.RightShift)) {
            StartSwingRightAnimation();
        }
    }

    private void StartSwingLeftAnimation() {
        mechAnim.SetBool("swingLeft", true);
    }

    public void EndSwingLeftAnimation() {
        mechAnim.SetBool("swingLeft", false);
        mechAnim.SetBool("swingRight", false);
    }

    private void StartSwingRightAnimation() {
        mechAnim.SetBool("swingRight", true);
    }

    public void EndSwingRightAnimation() {
        mechAnim.SetBool("swingRight", false);
        mechAnim.SetBool("swingLeft", false);
    }
}
