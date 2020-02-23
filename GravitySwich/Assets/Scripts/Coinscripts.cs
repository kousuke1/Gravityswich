using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinscripts : MonoBehaviour
{
   
    public GameObject coin;
    public float ichiy;
    public float ichix;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loop());
    }

    // Update is called once per frame
    void Update()
    {
        ichiy = Random.Range(1, 5);
        ichix = Random.Range(1,100);
    }
    private IEnumerator loop() {
        while (true) {
            yield return new WaitForSeconds(1f);
            onTimer();
        }
    }
    private void onTimer(){
     Instantiate(coin,new Vector3( ichix, ichiy, 0),Quaternion.identity);
    }


}
