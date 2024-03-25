using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundController : MonoBehaviour
{   
    [Range(1f,1f)]
    public float ScrollSpeed = 0.5f;
    private float offSet;
    private Material material;

    
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet +=(Time.deltaTime * ScrollSpeed)/ 10f;
        material.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
    }
}
