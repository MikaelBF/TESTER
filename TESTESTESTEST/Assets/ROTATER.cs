﻿using UnityEngine;
using System.Collections;

public class ROTATER : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
    {
        gameObject.transform.Rotate(Vector3.up, 1);
	}
}
