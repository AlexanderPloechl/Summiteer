using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisibleOnClick : MonoBehaviour
{
    public GameObject canvas;
    private bool isShowing=false;
    // Start is called before the first frame update

    public void Start(){
        canvas.SetActive(isShowing);
    }
    public void MakeVisible(){
        isShowing=!isShowing;
        canvas.SetActive(isShowing);
    }
}
