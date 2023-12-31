using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBarController : MonoBehaviour {
    public static UIHealthBarController instance { get; private set; }
    
    public Image mask;

    
    private float originalSize;
    // Start is called before the first frame update
    
    void Awake()
    {
        instance = this;
    }
    
    void Start() {
        originalSize = mask.rectTransform.rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetValue(float value) {
        mask.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, originalSize * value);
    }
}
