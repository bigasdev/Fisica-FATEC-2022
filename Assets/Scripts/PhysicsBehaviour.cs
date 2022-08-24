using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBehaviour : MonoBehaviour
{
    //[SerializeField] protected Vector3 accelerationRate;
    [SerializeField] protected Vector3 currentAcceleration;

    [SerializeField] protected float mass = 2f;
    [SerializeField] protected float moveSpeed = 3f;
    
    [SerializeField] protected Vector3[] forces;
    [SerializeField] protected Vector3 fr;

    [SerializeField] Vector3 acceleration;

    void FixedUpdate(){
        Fr();
        acceleration = GetAcceleration();
        AddAcceleration();

        this.transform.position += currentAcceleration * Time.deltaTime;
    }

    void AddAcceleration(){
        currentAcceleration += acceleration * Time.deltaTime;
    }

    protected Vector3 Fr(){
        var v = Vector3.zero;
        foreach(var f in forces){
            v += f;
        }
        fr = v;
        return v;
    }
    
    protected Vector3 GetAcceleration(){
        return fr/mass;
    }
}
