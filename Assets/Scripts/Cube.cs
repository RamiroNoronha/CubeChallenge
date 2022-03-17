using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float xPosition;
    public float yPosition;
    public float zPosition;
    public float scale;
    public float rColor;
    public float gColor;
    public float bColor;
    public float oppacity;
    public float time;
    public bool rightDirection = true;

    void Start()
    {
        xPosition = Random.Range(0.0f, 5.0f);
        yPosition = Random.Range(0.0f, 5.0f);
        zPosition = Random.Range(0.0f, 5.0f);
        scale = Random.Range(1.0f, 4.0f);



        transform.position = new Vector3(xPosition, yPosition, zPosition);
        transform.localScale = Vector3.one * scale;



    }
    
    void Update()
    {
        if (transform.position.x >= xPosition +10 || transform.position.x <= xPosition -10)
        {
            rColor = Random.Range(0.0f, 1.0f);
            gColor = Random.Range(0.0f, 1.0f);
            bColor = Random.Range(0.0f, 1.0f);
            oppacity = Random.Range(0.1f, 1.0f);
            Material material = Renderer.material;
            material.color = new Color(rColor, gColor, bColor, oppacity);

        }


        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        if(transform.position.x < xPosition + 10 && rightDirection)
        {
            transform.Translate((new Vector3(1, 0, 0)) * Time.deltaTime * 15);
            
        }
        else if(transform.position.x > xPosition - 10)
        {
            transform.Translate((new Vector3(-1, 0, 0)) * Time.deltaTime * 15);
            rightDirection = false;
        }
        else if(transform.position.x <= xPosition - 10)
        {
            rightDirection = true;
        }
        
    }
}
