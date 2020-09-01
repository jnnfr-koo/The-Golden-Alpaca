using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public ArrayList hearts = new ArrayList();
    public Sprite[] healthSprites = new Sprite[3];

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;
        for (int i = 0; i < maxHealth; i++)
        {

        }

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Plus))
        {
            //TODO: Increase health by 1
        }
        else if (Input.GetKeyDown(KeyCode.Minus))
        {
            //TODO: Decrease health by 1
        }
    }
}
