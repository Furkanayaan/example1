using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployStar : MonoBehaviour {

    public GameObject starPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    private Transform Player;


    // Start is called before the first frame update
    void Start() {
        StartCoroutine(starWave());
        
    }

    
    private void spawnStar() {
        GameObject a = Instantiate(starPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(0, screenBounds.y * 2));
    
    }

    IEnumerator starWave() {
        while (true) {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            yield return new WaitForSeconds(respawnTime);
            spawnStar();
        }

    }
}
