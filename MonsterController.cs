using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterController : MonoBehaviour
{
	Transform monster_transform;
	public GameObject mon;
	Transform mon_transform;
	public GameObject mones;
	Transform mones_transform;

    // Start is called before the first frame update
    void Start()
    {
        monster_transform = GetComponent<Transform>();
        mon_transform = mon.GetComponent<Transform>();
        mones_transform = mones.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    	monster_transform.Translate(0,0,4f);
    	mon_transform.Translate(0,0,4f);
    	mones_transform.Translate(0,0,4f);
    	SceneManager.LoadScene("scene5");
    	
    }
}
