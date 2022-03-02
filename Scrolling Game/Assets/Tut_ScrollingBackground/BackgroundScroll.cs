/*Namespaces*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Class*/
public class BackgroundScroll : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public int xVelocity, yVelocity;

    private void Awake()
     {
         material=GetComponent<Renderer>().material;


    }

    // Method 
    //Start is called before the first frame update
    void Start()
    {
        //Statements
        // offset = new Vector2(xVelocity,yVelocity);
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(xVelocity,yVelocity);
        material.mainTextureOffset += offset*Time.deltaTime;
        
    }
}
