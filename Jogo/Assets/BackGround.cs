using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public MeshRenderer fundo;
    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        fundo = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        fundo.material.mainTextureOffset += new Vector2(speedX * Time.deltaTime, speedY * Time.deltaTime);

    }
}
