using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSpawn : MonoBehaviour
{

    public GameObject prefab;
    public Camera mainCamera;

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButtonDown(0)) {
            Vector3 touchPos = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
            Instantiate(prefab, touchPos, Quaternion.identity);



        }
        
    }
}
