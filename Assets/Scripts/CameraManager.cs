using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] float moveSpeed = 4f;

    void Update(){
        this.transform.position = Vector3.MoveTowards(this.transform.position, cube.transform.position, moveSpeed * Time.deltaTime);
    }
}
