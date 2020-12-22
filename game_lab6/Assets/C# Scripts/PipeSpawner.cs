﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;       

    void Start()
    {
        StartCoroutine(Spawner());  // включаем корутину "Spawner" 
    }

    IEnumerator Spawner()      
    {
        while (true)                // бесконечный цикл While - работает
        {
            yield return new WaitForSeconds(2);     // ждем 2 секунды
            float rand = Random.Range(-1f, 4f);     // рандомная позиция от -1 до 4 (чтоб удобнее было)
            GameObject newPipes = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);     // переносим отвественность на новый gameObject и создаем префаб
            Destroy(newPipes, 10);  // удаление нового gameObject'a через 10 секунд (если б удаляли Pipes - то ничего б не заработало)
        }
    }


}