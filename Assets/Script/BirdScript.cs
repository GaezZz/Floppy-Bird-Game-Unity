using UnityEngine;

public class BirdScript : MonoBehaviour
{

    //le paso el rigid body, de normal solo coge del inspector la parte del nombre y el transform
    public Rigidbody2D myRigidBody;  //publico para verlo en las opciones, le digo que la cosa a guardar es un componente rigidbody y el nombre para referirme a el ahora en el script y cambiar propiedades
    public float flapStrength;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //con el if le digo que solo se haga esta parte del codigo cuando se apriete el boton especifico
        if (Input.GetKeyDown(KeyCode.Space)){

        myRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

    }
}
