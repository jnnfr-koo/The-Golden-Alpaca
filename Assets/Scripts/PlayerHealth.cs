using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class PlayerHealth : MonoBehaviour
{
    [Header("Health Stats")]
    public float maxHealth;
    public float currentHealth;

    [Header("Heart Assets")]
    public GameObject heartStorage;
    [Space]
    public GameObject emptyHeart;
    public GameObject halfHeart;
    public GameObject fullHeart;

    private float healthIncrement = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 3;

        for (int i = 0; i < maxHealth; i++)
        {
            Instantiate(emptyHeart, heartStorage.transform);
        }

        currentHealth = maxHealth;
        updateHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //Increase health by one half
        {
            currentHealth += healthIncrement;
            updateHealth();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) //Decrease health by one half
        {
            currentHealth -= healthIncrement;
            updateHealth();
        }
    }

    private void updateHealth()
    {
        if (currentHealth > maxHealth) //Check if health goes over max health
        {
            currentHealth = maxHealth;
        }
        else
        {
            foreach (Transform heart in transform)
            {
                Destroy(heart.gameObject);
            }

            //TODO: Allow for multiple empty hearts
            for (int i = 0; i < maxHealth; i++)
            {
                if ((currentHealth > i) && (currentHealth < i + 1))
                {
                    Instantiate(halfHeart, heartStorage.transform);
                }
                else if (currentHealth == i)
                {
                    Instantiate(emptyHeart, heartStorage.transform);
                }
                else
                {
                    Instantiate(fullHeart, heartStorage.transform);
                }
            }
        }
    }
}
