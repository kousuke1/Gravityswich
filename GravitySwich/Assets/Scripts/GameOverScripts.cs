using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScripts : MonoBehaviour
{
    public GameObject objTarget;
    public Vector3 offset;

   private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Stage"){
            Debug.Log("e?");
            SceneManager.LoadScene("GameOver");
        }
    }
 

	void Start () {
		updatePostion();
	}
	
	void LateUpdate () {
		updatePostion();
	}
	
	void updatePostion()
	{
		Vector3 pos = objTarget.transform.localPosition;
		transform.localPosition = pos + offset;
	}


}
