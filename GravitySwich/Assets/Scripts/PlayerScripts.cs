using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{

    public bool guraviteyCheck;
    private Rigidbody rd;
    public int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;
        transform.position += transform.right * speed * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space) && guraviteyCheck){
            Debug.Log("zyuuryoku");
            Physics.gravity = new Vector3(0,10.0f,0);
            guraviteyCheck = false;
        }else if(Input.GetKeyDown(KeyCode.Space) && guraviteyCheck == false){
            Physics.gravity = new Vector3(0,-10.0f,0);
            guraviteyCheck = true;
        }
        
    }
}
