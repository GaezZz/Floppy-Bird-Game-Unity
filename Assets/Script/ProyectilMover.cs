using UnityEngine;
using UnityEngine.UIElements;

public class ProyectilMover : MonoBehaviour
{

    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (Vector3.right * moveSpeed ) * Time.deltaTime;
    }
}
