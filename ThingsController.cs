using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingsController : MonoBehaviour
{
	Transform thing_transform;
	public GameObject text;
	Transform text_transform;
	
    // Start is called before the first frame update
    void Start()
    {
        thing_transform = GetComponent<Transform>();
        text_transform = text.GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    	Destroy(text);
    	
    }
}
