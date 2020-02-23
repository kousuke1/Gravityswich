using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointscripts : MonoBehaviour
{
    public GameObject coin;
     public static int point = 0;
     public GameObject PointText = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text Pt = PointText.GetComponent<Text> ();
        Pt.text = "Score:" + point;
    }
        public void OnTriggerEnter(Collider collider){
        if(collider.gameObject.tag =="Player"){
            point += 1;
            Destroy(this.gameObject);
            Debug.Log(point);
        }
    }
}
