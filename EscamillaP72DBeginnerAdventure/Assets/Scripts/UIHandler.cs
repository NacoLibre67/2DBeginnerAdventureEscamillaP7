using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class UIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private VisualElement m_Healthbar;
    public static UIHandler instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
     UIDocument document = 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
