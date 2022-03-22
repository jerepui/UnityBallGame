using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    [SerializeField] Transform platform = null;
    //The intensity of turning the platform makes when the corresponding keys are pressed.
    //public variable so it can be changed in the Unity Editor to test which value works best.
    [SerializeField] float turnStrength = 10.0f;

    
    float tiltX = 0f;
    float tiltZ = 0f;




    // Start is called before the first frame update
    void Start() {

        
    }

    // Update is called once per frame
    void Update() {

        UpdateRotation();
    }

    void UpdateRotation() {

        Vector2 rotDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rotDir.Normalize();

        tiltX += rotDir.x * turnStrength;
        tiltX = Mathf.Clamp(tiltX, -40.0f, 40.0f);

        tiltZ += rotDir.y * turnStrength;
        tiltZ = Mathf.Clamp(tiltZ, -40.0f, 40.0f);

        platform.localEulerAngles = Vector3.right * tiltX + Vector3.forward * tiltZ;

    }
}
