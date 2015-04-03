using UnityEngine;
using System.Collections;

public class Bullet_creator : MonoBehaviour {

    public GameObject thePrefab;
    public Player myPlayer;
    GameObject go;

    public GameObject instance;
	// Use this for initialization
    void Start()
    {
        
    }
	
	// Update is called once per frame
    void Update()
    {
        go = GameObject.FindGameObjectWithTag("Player");
        Vector3 playerKonum = go.transform.position;
        playerKonum.x = playerKonum.x + 1;
        Fire(playerKonum);
            
    }

    void Fire(Vector3 playerKonum)
    {
        if (Input.touchCount > 0)
        {
            Vector3 myTouch = Input.GetTouch(0).position;
            if (Screen.width / 2.0f < myTouch.x)
            {
                instance = new GameObject();
                instance = Instantiate(thePrefab, playerKonum, transform.rotation) as GameObject;
            }
            
        }
    }
}
