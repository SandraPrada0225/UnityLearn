using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        //tomamos el largo del fondo y loo dividimos en 2 para obtener la mitad 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        

    }

    // Update is called once per frame
    void Update()
    {
        //si la posicion del fondo en menor a la posicion inical menos un desface entonces 
        //la posicion del fondo regresa a la posicion inicial
        if(transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
