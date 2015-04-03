using UnityEngine;
using System.Collections;

public class Collider : MonoBehaviour {

    int value = 1;
    GameObject scoreManager;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Enemy" || col.gameObject.name=="EnemyFab(Clone)" || col.gameObject.name =="EnemyFab")
        {
            Destroy(col.gameObject);
            ScoreManager.score += value;
        }
    }
    
}
