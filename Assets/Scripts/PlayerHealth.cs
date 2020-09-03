using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public GameObject heartStorage;
    public Sprite[] healthSprites;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;
        healthSprites = new Sprite[(int) maxHealth];
        for (int i = 0; i < 1; i++)
        {
            //TODO: Add heart sprites dynamically to GUI
            //Image image = gameObject.AddComponent<Image>();
            //image.sprite = healthSprites[0];
            //image.transform.SetParent(heartStorage.transform, false);
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
