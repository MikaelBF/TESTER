using UnityEngine;
using System.Collections;

public class MOVER : MonoBehaviour {
    private float move = 1;
	// Update is called once per frame
	void Update () 
    {
        gameObject.transform.Translate(Vector3.left * move/10);
        move += 1 * Time.deltaTime;
        if (move > 3 || move < -3)
        {
            move = -move;
        }
	}
}
