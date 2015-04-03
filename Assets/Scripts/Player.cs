using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float fSpeed = 1;
    Vector3 v3NextPos;
    public GameObject Prefab_Bullet; //Needs to be declared as public to be seen in editor // prefab otomatik üretim icin gerekli
    public Vector3 bullet_position; // BattleStar dan cikacak olan ateş

    // Use this for initialization
    void Start()
    {
        //Walk();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void Walk()
    {
        if (Input.touchCount > 0) // herhangi bir şeye bastıysak..
        {
            Vector3 myTouch = Input.GetTouch(0).position;

            if (Screen.width / 2.0f > myTouch.x)
            {
                if (Screen.height / 2.0f > myTouch.y)
                {
                    v3NextPos.x = this.transform.position.x;
                    v3NextPos.y = this.transform.position.y - fSpeed;
                    v3NextPos.z = 0;

                    this.transform.position = v3NextPos;
                }
                else
                {
                    v3NextPos.x = this.transform.position.x;
                    v3NextPos.y = this.transform.position.y + fSpeed;
                    v3NextPos.z = 0;

                    this.transform.position = v3NextPos;
                }
            }

        } 

     }

}
    
