using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToFace : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 transPos = transform.position;
		transform.LookAt(transPos + Camera.main.transform.rotation * Vector3.forward,
			Camera.main.transform.rotation * Vector3.up);
    }
}
