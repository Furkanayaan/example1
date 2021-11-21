using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Height : MonoBehaviour
{
    [SerializeField]
    private Transform checkpoint;

    [SerializeField]
    private Text heightText;

    private float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        height = (transform.position.y - checkpoint.transform.position.y);

        heightText.text = "Height: " + height.ToString("F1") + " meters ";

        

    }
}
