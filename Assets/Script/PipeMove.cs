using UnityEngine;

public class PipeMove : MonoBehaviour
{

    public float moveSpeed = 5;

    public float deadZone = -45;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        //si pasa mas alla de la zona maxima se elimina, asi no tengo infinitos tubos
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
