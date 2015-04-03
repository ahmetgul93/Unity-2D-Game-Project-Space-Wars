using UnityEngine;
using System.Collections;

public class BulletSpeed : MonoBehaviour {
    public float fSpeed = 1;
    Vector3 playerKonum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Fly();
	}

    void Fly()
    {
      //  Vector3 myTouch = Input.GetTouch(0).position;
       // if (Screen.width / 2.0f < myTouch.x)
      //  {


            playerKonum.x = this.transform.position.x + fSpeed;
            playerKonum.y = this.transform.position.y;
            playerKonum.z = 0;

            this.transform.position = playerKonum;
     //   }

    }
}
