using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePainting : MonoBehaviour
{
    public Material texture;
    public GameObject canvasImage;

    public float width = 0f;
    public float height = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCanvas()
    {
        canvasImage.GetComponent<MeshRenderer>().material = texture;
        var newScale = new Vector3( width,
            canvasImage.transform.localScale.y,height
       );
        canvasImage.transform.localScale = newScale;
    }
}
