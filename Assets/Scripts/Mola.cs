using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mola : MonoBehaviour
{
    [SerializeField] protected Vector3 currentAcceleration;
    [SerializeField] protected Vector3 acceleration;
    [SerializeField] float constanteElastica = -2;
    [SerializeField] float mass = 4;

    void FixedUpdate(){
        AddAcceleration();
        GetAcceleration();

        this.transform.position += currentAcceleration * Time.deltaTime;
    }
    
    void AddAcceleration(){
        currentAcceleration += acceleration * Time.deltaTime;
    }

    protected float Fr(){
        return constanteElastica*transform.position.y;
    }

    protected void GetAcceleration(){
        acceleration.y = Fr()/mass;
    }
}
