using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : Hero, IMainCharacter, IControllable
{
    public MainCharacter(CharacterSheet sheet, CharacterAttributes characterStats) : base(sheet, characterStats)
    {
    }

    public void ProcessInput()
    {
        //
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}