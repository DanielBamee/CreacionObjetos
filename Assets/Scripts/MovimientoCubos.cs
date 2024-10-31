using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubos : MonoBehaviour
{
    [SerializeField]
    public bool inverted;
    [SerializeField]
    public float velocidad = 3f;
    

    // Start is called before the first frame update
    private void Awake()
    {
        if (inverted == true)
        {
            velocidad = velocidad * -1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoZ = Input.GetAxis("Vertical");
        Vector3 mov = new Vector3(movimientoX, 0.0f, movimientoZ) * velocidad * Time.deltaTime;
        transform.Translate(mov);
    }
}
