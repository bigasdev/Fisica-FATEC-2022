using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsBehaviourForce : MonoBehaviour
{
    [SerializeField] protected Vector3 currentAcceleration;
    [SerializeField] protected Vector3 acceleration;
    [SerializeField] protected float mass;
    [SerializeField] protected float constante;

    void FixedUpdate(){
        AddAcceleration();
        GetAcceleration();

        this.transform.position += currentAcceleration * Time.deltaTime;
    }

    void AddAcceleration(){
        currentAcceleration += acceleration * Time.deltaTime;
    }

    protected float Fr(){
        return mass*constante;
    }
    
    protected void GetAcceleration(){
        acceleration.y = Fr()/mass;
    }
}
