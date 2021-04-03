using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.ParticleSystemJobs;

public class scr_menu : MonoBehaviour
{
    public int FreeWorkers = 0, WoodWorkers = 0, StoneWorkers = 0, IronWorkers = 0, GoldWorkers = 0;
    public int Wood = 0, Stone = 0, Iron = 0, Gold = 0, Soldiers = 0, Spells = 0;
    public int WoodScaler = 1, StoneScaler = 1, IronScaler = 1, GoldScaler = 1;
    public int MaxTimer = 100;
    public int[] UpgradeCost, WorkersCost;
    public int WoodLevel = 0, StoneLevel = 0, IronLevel = 0, GoldLevel = 0;
    public GameObject ButtonWoodPlus, ButtonWoodMinus, ButtonWoodCount;
    public GameObject ButtonStonePlus, ButtonStoneMinus, ButtonStoneCount;
    public GameObject ButtonIronPlus, ButtonIronMinus, ButtonIronCount;
    public GameObject ButtonGoldPlus, ButtonGoldMinus, ButtonGoldCount;
    public GameObject ButtonFreeWorkers;
    public GameObject WoodButton, StoneButton, IronButton, GoldButton;
    public GameObject ButtonWoodUpgrade, ButtonStoneUpgrade, ButtonIronUpgrade, ButtonGoldUpgrade, ButtonWorkerUpgrade, ButtonSoldierNew, ButtonSpellNew;
    public GameObject TextWoodUpgrade, TextStoneUpgrade, TextIronUpgrade, TextGoldUpgrade, TextWorkerCost, TextSoldiers, TextSpells;
    public GameObject ParticleWood, ParticleStone, ParticleIron, ParticleGold;

    private int Timer = 0;
    private int mode = 0; // 0 - wood, 1 - stone, 2 - iron, 3 - gold
    private int AllWorkers;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        Timer = (Timer + 1) % MaxTimer;

        if (Timer == 0)
        {
            Wood += WoodWorkers*WoodScaler;
            Stone += StoneWorkers*StoneScaler;
            Iron += IronWorkers*IronScaler;
            Gold += GoldWorkers*GoldScaler;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        AllWorkers = FreeWorkers + WoodWorkers + StoneWorkers + IronWorkers + GoldWorkers;

        if (FreeWorkers <= 0)
        {
            ButtonWoodPlus.GetComponent<Button>().interactable = false;
            ButtonStonePlus.GetComponent<Button>().interactable = false;
            ButtonIronPlus.GetComponent<Button>().interactable = false;
            ButtonGoldPlus.GetComponent<Button>().interactable = false;
        }
        else
        {
            ButtonWoodPlus.GetComponent<Button>().interactable = true;
            ButtonStonePlus.GetComponent<Button>().interactable = true;
            ButtonIronPlus.GetComponent<Button>().interactable = true;
            ButtonGoldPlus.GetComponent<Button>().interactable = true;
        }

        


        if (Gold < 10 || Iron < 25)
            ButtonSoldierNew.GetComponent<Button>().interactable = false;
        else
            ButtonSoldierNew.GetComponent<Button>().interactable = true;

        if (Gold < 50)
            ButtonSpellNew.GetComponent<Button>().interactable = false;
        else
            ButtonSpellNew.GetComponent<Button>().interactable = true;

        if (AllWorkers < 5)
        {
            if (Wood < WorkersCost[AllWorkers] || Stone < WorkersCost[AllWorkers] || Iron < WorkersCost[AllWorkers] || Gold < WorkersCost[AllWorkers])
                ButtonWorkerUpgrade.GetComponent<Button>().interactable = false;
            else
                ButtonWorkerUpgrade.GetComponent<Button>().interactable = true;
        }
        else
            ButtonWorkerUpgrade.GetComponent<Button>().interactable = false;


        if (WoodLevel < 3)
        {
            if (Wood <= UpgradeCost[WoodLevel] || Stone <= UpgradeCost[WoodLevel])
                ButtonWoodUpgrade.GetComponent<Button>().interactable = false;
            else
                ButtonWoodUpgrade.GetComponent<Button>().interactable = true;
        }
        else
            ButtonWoodUpgrade.GetComponent<Button>().interactable = false;

        if (StoneLevel < 3)
        {
            if (Wood <= UpgradeCost[StoneLevel] || Stone <= UpgradeCost[StoneLevel])
                ButtonStoneUpgrade.GetComponent<Button>().interactable = false;
            else
                ButtonStoneUpgrade.GetComponent<Button>().interactable = true;
        }
        else
            ButtonStoneUpgrade.GetComponent<Button>().interactable = false;

        if (IronLevel < 3)
        {
            if (Wood <= UpgradeCost[IronLevel] || Stone <= UpgradeCost[IronLevel])
                ButtonIronUpgrade.GetComponent<Button>().interactable = false;
            else
                ButtonIronUpgrade.GetComponent<Button>().interactable = true;
        }
        else
            ButtonIronUpgrade.GetComponent<Button>().interactable = false;

        if (GoldLevel < 3)
        {
            if (Wood <= UpgradeCost[GoldLevel] || Stone <= UpgradeCost[GoldLevel])
                ButtonGoldUpgrade.GetComponent<Button>().interactable = false;
            else
                ButtonGoldUpgrade.GetComponent<Button>().interactable = true;
        }
        else
            ButtonGoldUpgrade.GetComponent<Button>().interactable = false;


        if (WoodWorkers <= 0)
            ButtonWoodMinus.GetComponent<Button>().interactable = false;
        else
            ButtonWoodMinus.GetComponent<Button>().interactable = true;

        if (StoneWorkers <= 0)
            ButtonStoneMinus.GetComponent<Button>().interactable = false;
        else
            ButtonStoneMinus.GetComponent<Button>().interactable = true;

        if (IronWorkers <= 0)
            ButtonIronMinus.GetComponent<Button>().interactable = false;
        else
            ButtonIronMinus.GetComponent<Button>().interactable = true;

        if (GoldWorkers <= 0)
            ButtonGoldMinus.GetComponent<Button>().interactable = false;
        else
            ButtonGoldMinus.GetComponent<Button>().interactable = true;


        ButtonFreeWorkers.GetComponent<Text>().text = "Free workers:" + FreeWorkers.ToString();

        ButtonWoodCount.GetComponent<Text>().text = WoodWorkers.ToString();
        ButtonStoneCount.GetComponent<Text>().text = StoneWorkers.ToString();
        ButtonIronCount.GetComponent<Text>().text = IronWorkers.ToString();
        ButtonGoldCount.GetComponent<Text>().text = GoldWorkers.ToString();

        WoodButton.GetComponent<Text>().text = "Wood: " + Wood.ToString();
        StoneButton.GetComponent<Text>().text = "Stone: " + Stone.ToString();
        IronButton.GetComponent<Text>().text = "Iron: " + Iron.ToString();
        GoldButton.GetComponent<Text>().text = "Gold: " + Gold.ToString();

        TextSoldiers.GetComponent<Text>().text = "Soldiers: " + Soldiers.ToString();
        TextSpells.GetComponent<Text>().text = "Spells: " + Spells.ToString();
    }

    //Распределение рабочих

    public void ButtonWoodPlus_click()
    {
        WoodWorkers++;
        FreeWorkers--;
    }
    public void ButtonWoodMinus_click()
    {
        WoodWorkers--;
        FreeWorkers++;
    }

    public void ButtonStonePlus_click()
    {
        StoneWorkers++;
        FreeWorkers--;
    }
    public void ButtonStoneMinus_click()
    {
        StoneWorkers--;
        FreeWorkers++;
    }

    public void ButtonIronPlus_click()
    {
        IronWorkers++;
        FreeWorkers--;
    }
    public void ButtonIronMinus_click()
    {
        IronWorkers--;
        FreeWorkers++;
    }

    public void ButtonGoldPlus_click()
    {
        GoldWorkers++;
        FreeWorkers--;
    }
    public void ButtonGoldMinus_click()
    {
        GoldWorkers--;
        FreeWorkers++;
    }

    //Клик на основную кнопку

    public void ButtonMining()
    {
        var emitParams = new ParticleSystem.EmitParams();

        switch (mode)
        {
            case 0:
                Wood += WoodScaler;
                ParticleWood.GetComponent<AudioSource>().Play();
                ParticleWood.GetComponent<ParticleSystem>().Emit(emitParams, WoodScaler);
                break;
            case 1:
                Stone += StoneScaler;
                ParticleStone.GetComponent<AudioSource>().Play();
                ParticleStone.GetComponent<ParticleSystem>().Emit(emitParams, StoneScaler);
                break;
            case 2:
                Iron += IronScaler;
                ParticleIron.GetComponent<AudioSource>().Play();
                ParticleIron.GetComponent<ParticleSystem>().Emit(emitParams, IronScaler);
                break;
            case 3:
                Gold += GoldScaler;
                ParticleGold.GetComponent<AudioSource>().Play();
                ParticleGold.GetComponent<ParticleSystem>().Emit( emitParams, GoldScaler);
                break;
        }
        

    }

    //Смена режимов

    public void ChangeModeWood()
    {
        mode = 0;
    }
    public void ChangeModeStone()
    {
        mode = 1;
    }
    public void ChangeModeIron()
    {
        mode = 2;
    }
    public void ChangeModeGold()
    {
        mode = 3;
    }

    //Улучшения и покупки

    public void WoodUpgrade()
    {
        WoodScaler++;
        Wood -= UpgradeCost[WoodLevel];
        Stone -= UpgradeCost[WoodLevel];
        WoodLevel++;
        TextWoodUpgrade.GetComponent<Text>().text = "Upgrade woodcutter:\n" + UpgradeCost[WoodLevel].ToString() + " Wood and Stone";
    }
    public void StoneUpgrade()
    {
        StoneScaler++;
        Wood -= UpgradeCost[StoneLevel];
        Stone -= UpgradeCost[StoneLevel];
        StoneLevel++;
        TextStoneUpgrade.GetComponent<Text>().text = "Upgrade stone quarry:\n" + UpgradeCost[StoneLevel].ToString() + " Wood and Stone";
    }
    public void IronUpgrade()
    {
        IronScaler++;
        Wood -= UpgradeCost[IronLevel];
        Stone -= UpgradeCost[IronLevel];
        IronLevel++;
        TextIronUpgrade.GetComponent<Text>().text = "Upgrade iron mine:\n" + UpgradeCost[IronLevel].ToString() + " Wood and Stone";
    }
    public void GoldUpgrade()
    {
        GoldScaler++;
        Wood -= UpgradeCost[GoldLevel];
        Stone -= UpgradeCost[GoldLevel];
        GoldLevel++;
        TextGoldUpgrade.GetComponent<Text>().text = "Upgrade trading post:\n" + UpgradeCost[GoldLevel].ToString() + " Wood and Stone";
    }
    public void NewWorker()
    {
        Wood -= WorkersCost[FreeWorkers + WoodWorkers + StoneWorkers + IronWorkers + GoldWorkers];
        Stone -= WorkersCost[FreeWorkers + WoodWorkers + StoneWorkers + IronWorkers + GoldWorkers];
        Iron -= WorkersCost[FreeWorkers + WoodWorkers + StoneWorkers + IronWorkers + GoldWorkers];
        Gold -= WorkersCost[FreeWorkers + WoodWorkers + StoneWorkers + IronWorkers + GoldWorkers];
        FreeWorkers++;
        AllWorkers = FreeWorkers + WoodWorkers + StoneWorkers + IronWorkers + GoldWorkers;
        TextWorkerCost.GetComponent<Text>().text = "Buy new worker:\n" + WorkersCost[AllWorkers].ToString() + " all resources";
    }
    public void NewSoldier()
    {
        Iron -= 25;
        Gold -= 10;
        Soldiers++;
    }
    public void NewSpell()
    {
        Gold -= 50;
        Spells++;
    }

}
