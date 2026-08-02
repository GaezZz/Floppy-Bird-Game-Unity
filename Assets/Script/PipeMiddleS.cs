using UnityEngine;
//ESTE SCRIPT ES PARA SALTAR UN TRIGGER AL PASAR UNA PIPE Y ASI SUMAR PUNTOS
public class PipeMiddleS : MonoBehaviour
{

    public LogicScript logic; //al igual que con rigidbody pero para decirle el script de otro componente

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //le digo que nada mas empezar busque el objeto con esa etiqueta en concreto Y (por eso uso el punto) coja todos los valores y cosas que tenga ese script (GetComponent)
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) //metodo para coger cuando esta "triggereando" al tocarse con algo
    {
        if (collision.gameObject.layer == 3) //le digo que si la zona de trigger se encuentra con algo que este en la capa 3 (solo el pajaro) se active el sumar puntos
        {

            logic.addScore(1);
        }
    }

}

