using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTowardsMouse3D : MonoBehaviour {

    public Camera Cam;

	void Start () {
		
        if(Cam == null)
        {
            Cam = Camera.main;

            if(Cam == null)
            {
                Debug.LogError("No camera set up: |PointTowardsMouse3D|");
            }
        }

	}
	
	void Update () {

        Vector3 _rot;
        transform.LookAt(Cam.ScreenToWorldPoint(Input.mousePosition));
        _rot = transform.eulerAngles;
        transform.eulerAngles = new Vector3(0, _rot.y, 0);

	}

}
