using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

        // Use this for initialization
        void Start () {
                // 要素数5の配列を初期化
                int[] points = new int[5];

                // 配列の各要素に値を代入
                points [0] = 10;
                points [1] = 20;
                points [2] = 30;
                points [3] = 40;
                points [4] = 50;

                // 配列の要素を逆順に表示
                for (int i = 4; i >= 0; i--) {
                        Debug.Log (points [i]);
                }
        }
        
        // Update is called once per frame
        void Update () {
        }
}