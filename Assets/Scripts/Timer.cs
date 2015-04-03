using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	// Use this for initialization
    public float myTimer = 60.0f;
	void Start () {
	}
	
	// Update is called once per frame
	void Update() {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
        }
        if (myTimer <= 0)
        {
            StartCoroutine(End_Couroutine());
            Application.Quit();
        }
	}

    IEnumerator End_Couroutine()
    {
        Application.LoadLevel("endScene");
        yield return new WaitForSeconds(2);
    }
    
}

