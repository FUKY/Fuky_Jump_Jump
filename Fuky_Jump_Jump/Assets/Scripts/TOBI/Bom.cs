using UnityEngine;
using System.Collections;

public class Bom : MonoBehaviour {

    public float speedX;
    public float speedY;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedX, speedY);
	}

	
	// Update is called once per frame
	void Update () {
        //GetComponent<Rigidbody2D>().velocity = new Vector2(-5.0f, 5.0f);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("ad");
        if(col.gameObject.tag == "ground")
        {
           Debug.Log("ad");
            GetComponent<Rigidbody2D>().velocity = new Vector2(speedX, speedY);
        }
    }
}
