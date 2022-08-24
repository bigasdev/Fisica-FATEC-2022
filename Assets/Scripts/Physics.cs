using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    [SerializeField] protected Vector3 accelerationRate;
    [SerializeField] protected Vector3 currentAcceleration;

    [SerializeField] protected float mass = 2f;
    [SerializeField] protected float moveSpeed = 3f;
    
    [SerializeField] protected Vector3[] forces;
    [SerializeField] protected Vector3 fr;

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
