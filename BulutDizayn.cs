using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BulutDizayn : MonoBehaviour
public GameObject[] bulutlar = new GameObject[12]; //Prefabs for road with shiny objects
//I divide the prefab sand in two
    bool SonEkle = true;//the state of addition of the first litter
  bool BasEkle = false; //the state of addition of the second litter
  
  void Start()
    {
    }
   
    
//In order to select whether the prefab to be added is next to or below or above the previous prefab, 
// chose a random number and checked whether this number is odd or even
    
     void BulutDizayn()
    {
        if (SonEkle == true)
        {
            sayac = 6;
            while (sayac < 12)
            {
                int durum = Random.RandomRange(0, 100);
                if (durum % 2 == 0)//Zıpla
                {
                    if (bulutlar[sayac-1].gameObject.transform.position.y +1>= -0.5f)
                    {
                        bulutlar[sayac].gameObject.transform.position = bulutlar[sayac - 1].gameObject.transform.position + new Vector3(7.5f, 0, 0);
                    }
                    else
                    {
                        bulutlar[sayac].gameObject.transform.position = bulutlar[sayac - 1].gameObject.transform.position + new Vector3(7.5f, 1f, 0);
                    }
                
                }
                else
                {
                    if(bulutlar[sayac-1].gameObject.transform.position.y-1f<= -4f)
                    {
                        bulutlar[sayac].gameObject.transform.position = bulutlar[sayac - 1].gameObject.transform.position + new Vector3(7.5f, 0, 0);
                    }
                    else
                    {
                        bulutlar[sayac].gameObject.transform.position = bulutlar[sayac - 1].gameObject.transform.position + new Vector3(7.5f, -1f, 0);
                    }
         
                }
                sayac++;
            }
        }
        if (BasEkle == true)
        {
            sayac2 = 1;
            int durum = Random.RandomRange(0, 100);
            if (durum % 2 == 0)//Zıpla
            {
                if (bulutlar[11].gameObject.transform.position.y +1f >= -0.5f)
                {
                    bulutlar[0].gameObject.transform.position = bulutlar[11].gameObject.transform.position + new Vector3(7.5f, 0f, 0);
                }
                else
                {
                    bulutlar[0].gameObject.transform.position = bulutlar[11].gameObject.transform.position + new Vector3(7.5f, 1f, 0);
                }       
            }
            else
            {
                if (bulutlar[11].gameObject.transform.position.y -1f <= -4f)
                {
                    bulutlar[0].gameObject.transform.position = bulutlar[11].gameObject.transform.position + new Vector3(7.5f, 0, 0);
                }
                else
                {
                    bulutlar[0].gameObject.transform.position = bulutlar[11].gameObject.transform.position + new Vector3(7.5f, -1f, 0);
                }
                
            }
            while (sayac2 < 7)
            {
                durum = Random.RandomRange(0, 100);
                if (durum % 2 == 0)//Zıpla
                {
                    if (bulutlar[sayac2-1].gameObject.transform.position.y+ 1f>=-0.5f)
                    {
                        bulutlar[sayac2].gameObject.transform.position = bulutlar[sayac2 - 1].gameObject.transform.position + new Vector3(7.5f, 0f, 0);
                    }
                    else
                    {
                        bulutlar[sayac2].gameObject.transform.position = bulutlar[sayac2 - 1].gameObject.transform.position + new Vector3(7.5f, 1f, 0);
                    }
   
                }
                else
                {
                    if (bulutlar[sayac2-1].gameObject.transform.position.y-1f<= -4f)
                    {
                        bulutlar[sayac2].gameObject.transform.position = bulutlar[sayac2 - 1].gameObject.transform.position + new Vector3(7.5f, 0f, 0);
                    }
                    else
                    {
                        bulutlar[sayac2].gameObject.transform.position = bulutlar[sayac2 - 1].gameObject.transform.position + new Vector3(7.5f, -1f, 0);
                    }
         
                }
                sayac2++;
            }
        }

      void Update()
    {
     BulutEkle();//Infinite addition

    }
