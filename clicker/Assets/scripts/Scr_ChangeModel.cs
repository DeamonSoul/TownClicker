using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ChangeModel : MonoBehaviour
{
    public GameObject WoodModel, StoneModel, IronModel, GoldModel;
    public int CurrentBuilding = 0, NextBuilding = -1;
    public int Direction = 0, LowestPosition, HighestPosition;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*

    private void FixedUpdate()
    {
        if (Direction == -1)
        {
            WoodModel.GetComponent<Transform>().Translate(Vector3.down * Speed);
            StoneModel.GetComponent<Transform>().Translate(Vector3.down * Speed);
            IronModel.GetComponent<Transform>().Translate(Vector3.down * Speed);
            GoldModel.GetComponent<Transform>().Translate(Vector3.down * Speed);

            if (WoodModel.GetComponent<Transform>().position.y <= (float)LowestPosition)
            {
                Direction = 1;
                switch (CurrentBuilding)
                {
                    case 0:
                        WoodModel.SetActive(false);
                        break;
                    case 1:
                        StoneModel.SetActive(false);
                        break;
                    case 2:
                        IronModel.SetActive(false);
                        break;
                    case 3:
                        GoldModel.SetActive(false);
                        break;
                }

                switch (NextBuilding)
                {
                    case 0:
                        WoodModel.SetActive(true);
                        break;
                    case 1:
                        StoneModel.SetActive(true);
                        break;
                    case 2:
                        IronModel.SetActive(true);
                        break;
                    case 3:
                        GoldModel.SetActive(true);
                        break;
                }
            }
            
        }
        if (Direction == 1)
        {
            WoodModel.GetComponent<Transform>().Translate(Vector3.up * Speed);
            StoneModel.GetComponent<Transform>().Translate(Vector3.up * Speed);
            IronModel.GetComponent<Transform>().Translate(Vector3.up * Speed);
            GoldModel.GetComponent<Transform>().Translate(Vector3.up * Speed);

            if (WoodModel.GetComponent<Transform>().position.y >= (float)HighestPosition)
            {
                Direction = 0;
                CurrentBuilding = NextBuilding;
                NextBuilding = -1;
            }
        }
    }

    */

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeWood()
    {
        NextBuilding = 0;
        WoodModel.SetActive(false);
        StoneModel.SetActive(false);
        IronModel.SetActive(false);
        GoldModel.SetActive(false);

        WoodModel.SetActive(true);
        Direction = -1;
    }

    public void ChangeStone()
    {
        NextBuilding = 1;
        Direction = -1;

        WoodModel.SetActive(false);
        StoneModel.SetActive(false);
        IronModel.SetActive(false);
        GoldModel.SetActive(false);

        StoneModel.SetActive(true);
    }

    public void ChangeIron()
    {
        NextBuilding = 2;
        Direction = -1;
        WoodModel.SetActive(false);
        StoneModel.SetActive(false);
        IronModel.SetActive(false);
        GoldModel.SetActive(false);

        IronModel.SetActive(true);
    }

    public void ChangeGold()
    {
        NextBuilding = 3;
        Direction = -1;

        WoodModel.SetActive(false);
        StoneModel.SetActive(false);
        IronModel.SetActive(false);
        GoldModel.SetActive(false);

        GoldModel.SetActive(true);
    }

}
