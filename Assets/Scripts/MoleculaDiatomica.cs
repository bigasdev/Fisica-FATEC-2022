using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculaDiatomica : MonoBehaviour
{
    [SerializeField] GameObject[] esferas;
    [SerializeField] float k, mass, b;

    [SerializeField] Vector3 tamanho;
    [SerializeField] Vector3 distancia, amortecimento, fel, felMassa, felMassaNegativo, felMassaFrame, felMassaNegativoFrame;

    void FixedUpdate(){
        UpdateSpeed();
        //CalculateAmortecimento();
        
        esferas[0].transform.position += felMassaFrame * Time.deltaTime;
        esferas[1].transform.position += felMassaNegativoFrame * Time.deltaTime;
    }

    void UpdateSpeed(){
        distancia = esferas[0].transform.position - esferas[1].transform.position;

        fel = (distancia-tamanho)*(-k);


        felMassa = fel/mass;
        felMassaNegativo = (-fel)/mass;

        felMassaFrame += felMassa * Time.deltaTime;
        felMassaNegativoFrame += felMassaNegativo * Time.deltaTime; 
    }

    /*void CalculateAmortecimento(){
        amortecimento = (-b*felMassaFrame)-(-k*esferas[0].transform.position);

        felMassa = amortecimento/mass;
        felMassaNegativo = (-amortecimento)/mass;

        felMassaFrame += felMassa * Time.deltaTime;
        felMassaNegativoFrame += felMassaNegativo * Time.deltaTime;
    }*/
}
