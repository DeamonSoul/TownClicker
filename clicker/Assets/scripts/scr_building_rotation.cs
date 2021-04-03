using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_building_rotation : MonoBehaviour
{
    public float RotationSpeed = 4;
    public int timer = 0;
    public GameObject WoodModel;
    public GameObject StoneModel;
    public GameObject IronModel;
    public GameObject GoldModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        timer = (timer + 1) / 100;
        if (timer == 0)
        {
            WoodModel.transform.Rotate(0, RotationSpeed, 0);
            StoneModel.transform.Rotate(0, RotationSpeed, 0);
            IronModel.transform.Rotate(0, RotationSpeed, 0);
            GoldModel.transform.Rotate(0, RotationSpeed, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
