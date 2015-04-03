using UnityEngine;
using System.Collections;

public class Enemy_creator : MonoBehaviour {

	// Use this for initialization
    public GameObject thePrefab; //Needs to be declared as public to be seen in editor // prefab otomatik üretim icin gerekli
    public Vector3 position;
    // Use this for initialization
    //GameObject instance = new GameObject();
    void Start()
    {
      // GameObject instance = new GameObject();
        StartCoroutine(Creation_Couroutine()); // rutin hale getirdik yani 3 saniye bekleme yapacak asagida
    }
    IEnumerator Creation_Couroutine()
    {
       
        for (int i = 0; i < 100; i++)
        {
            position = new Vector3(Random.Range(-4f, 5f), Random.Range(-4f, 4f), 0f); // random yer uretiyoruz
            GameObject instance = new GameObject(); // oyun objesi olusturduk
            instance = Instantiate(thePrefab, position, transform.rotation) as GameObject; // objemizin türü ,  yeri vs.
            //objenin turu preFAb'dan cekiliyor , prefab a enemy scriptini baglamistik unity yardimi ile
            yield return new WaitForSeconds(2); // 2 saniye bekletiyor
        }
    }
}
