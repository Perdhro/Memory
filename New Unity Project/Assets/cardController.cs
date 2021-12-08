using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardController : MonoBehaviour
{
    public SpriteRenderer spr;
    public Sprite back;
    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        spr.sprite = back;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
