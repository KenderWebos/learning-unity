using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

[System.Serializable]
public struct ItemInventario
{
    public bool utilizable;
    public Sprite icono;
    public int precio;
    public int tamaño;
    public int userID;
}

public class data : MonoBehaviour
{
    [SerializeField] private string nombre = "Patricia";
    [SerializeField] private int edad = 32;
    public float timer;

    public TMP_Text consola;
    public List<string> alimentos;

    public enum Alimentos { Manzana, Pera, Naranja };
    public Alimentos alimentos_disponibles;

    public List<ItemInventario> inventory;

    void Start()
    {
        print("Hola mi nombre es " + nombre + " y tengo " + edad + " años");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            consola.text = timer + "";
        }
        else
        {
            consola.text = "BOOM!!!";
        }

    }
}
