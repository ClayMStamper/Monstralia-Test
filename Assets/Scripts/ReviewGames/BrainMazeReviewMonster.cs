using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainMazeReviewMonster : MonoBehaviour {

    public float speed;

    private void OnMouseDrag() {
        if (Input.GetMouseButton(0)) {
            transform.position += new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * speed;
        }
    }

}
