using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

        // Use this for initialization
        void Start () {
                // 要素数5の配列を初期化
                int[] array = new int[5];

                // 配列の各要素に値を代入
                array [0] = 10;
                array [1] = 20;
                array [2] = 30;
                array [3] = 40;
                array [4] = 50;

                // 配列の要素を逆順に表示
                for (int i = 0; i < 5; i++) {
                        Debug.Log (array [i]);
                }
                for (int i = 4; i >= 0; i--) {
                        Debug.Log (array [i]);
                }
        }
        
        // Update is called once per frame
        void Update () {
        }
}