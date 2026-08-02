using System;
using UnityEngine;

public class ProyectilSpawn : MonoBehaviour
{

    //le digo que prefab tiene que soltar
    public GameObject proyectil;

    public Boolean isDead = false; //si esta en pantalla no puedo tirar mas

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true)
        {
            //lo saco en el punto del spawn y el solo con el otro script se mueve
            Instantiate(proyectil, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        }
        
    }
}
