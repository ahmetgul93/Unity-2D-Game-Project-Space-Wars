using UnityEngine;
using System.Collections;
using System;

public class Enemy : MonoBehaviour {

    public Vector3 v3NextPos;
    DateTime s = System.DateTime.Now.AddSeconds(3);
    public float fSpeed = 1;
  

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        SendItem();

        
	}

    void SendItem()
    {
        var r = UnityEngine.Random.Range(-20,20);


        v3NextPos.x = this.transform.position.x + r*fSpeed;
        v3NextPos.y = this.transform.position.y + r*fSpeed;
        v3NextPos.z = 0;

        this.transform.position = v3NextPos;

    }
}
