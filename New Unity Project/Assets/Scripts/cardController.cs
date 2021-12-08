using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardController : MonoBehaviour
{
    public static cardController instance;
    public SpriteRenderer spr;
    public Sprite back;
    private void Awake()
    {
        instance = this;
        spr = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        spr.sprite = back;
        GameManagerScript.instance.addCard(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
