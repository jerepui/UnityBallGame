using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    //The intensity of turning the platform makes when the corresponding keys are pressed.
    //public variable so it can be changed in the Unity Editor to test which value works best.
    public float turnStrength;

    //TurnLimit prevents the platform from rotating too far in any direction.
    public float turnLimit;
    



    // Start is called before the first frame update
    void Start() {

        
    }

    // Update is called once per frame
    void Update() {

        
    }

    private void FixedUpdate() {

        //Rotates the platform in different directions when the corresponding WASD keys are pressed.
        //To make sure the platform keeps rotating in the chosen direction more than once, the current rotation of each axis is included in the calculation.
        //The platform turns only when the correct key is pressed and the platform hasn't already rotated over the turn limit.

       if(Input.GetKey(KeyCode.W) && transform.rotation.x < turnLimit) {

            transform.Rotate(transform.rotation.x + 0.05f * turnStrength, 0, 0);
        }

       if(Input.GetKey(KeyCode.S) && transform.rotation.x > turnLimit * -1f) {

            transform.Rotate(transform.rotation.x - 0.05f * turnStrength, 0,0 );
        }

       if(Input.GetKey(KeyCode.A) && transform.rotation.z < turnLimit) {

            transform.Rotate(0, 0, transform.rotation.z + 0.05f * turnStrength);
        }

        if (Input.GetKey(KeyCode.D) && transform.rotation.z > turnLimit * -1f) {

            transform.Rotate(0, 0, transform.rotation.z - 0.05f * turnStrength);
        }
    }
}
