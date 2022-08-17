using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBehaviourChild : MonoBehaviour
{
    [SerializeField] Vector3 accelerationRate;
    [SerializeField] Vector3 currentAcceleration;

    [SerializeField] float moveSpeed = 3f;

    [SerializeField] AnimationCurve smoothRate;
    [SerializeField] Transform wayPoint;

    void FixedUpdate(){
        AddAcceleration();

        this.transform.position += currentAcceleration * Time.deltaTime + (accelerationRate * Time.deltaTime*Time.deltaTime/2f);

        /*var d = smoothRate.Evaluate(Time.time);
        Debug.log(d);/
        this.transform.position = Vector3.MoveTowards(this.transform.position, wayPoint.position, d * moveSpeed * Time.deltaTime);*/
    }

    void AddAcceleration(){
        currentAcceleration += accelerationRate * Time.deltaTime;
    }
}
