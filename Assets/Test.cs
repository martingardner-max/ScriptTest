using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    
    void Start()
    {
        //�v�f���U�̔z�������������
        int[] array = new int[5];
        //�z��̊e�v�f�ɒl��������
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;
        
        //�z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //�z��̗v�f���t�ɕ\������
        for (int i = 4; i >=0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
