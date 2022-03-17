using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    private bool iniciar = true;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(iniciar == true)
        {
            Vector3 position = cube.transform.position;
            transform.position = new Vector3(position.x, position.y, position.z - 15);
        }
        iniciar = false;
    }
}
