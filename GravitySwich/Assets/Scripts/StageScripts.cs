using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScripts : MonoBehaviour
{
    public GameObject[] stage;
    // Start is called before the first frame update
    public int number;
    public int count = 0;
    public int x = 0;
    
    void Start()
    {
        StartCoroutine(loop());
    }

    // Update is called once per frame
    void Update()
    {
        number = Random.Range (0, stage.Length); 
    }
    
    private IEnumerator loop() {
        while (true) {
            yield return new WaitForSeconds(1f);
            onTimer();
        }
}
    private void onTimer() {
        if(count == 0){
            Instantiate(stage[number],new Vector3( x + 11, 0, 0),Quaternion.identity);
            count ++;
        }else if(count >= 1){
            Instantiate(stage[number],new Vector3(x + 5,0,0),Quaternion.identity);
            x = x + 5;
            count ++;
        }
}


}
