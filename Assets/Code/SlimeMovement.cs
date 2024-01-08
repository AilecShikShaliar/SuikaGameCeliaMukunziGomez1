using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{

    public float velocidadMovimiento = 4f;
    public string axe;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMovement = Input.GetAxis(axe);
        rb.velocity = new Vector2(0, HorizontalMovement).normalized * velocidadMovimiento;
    }
}