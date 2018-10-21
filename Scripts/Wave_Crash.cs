using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave_Crash : MonoBehaviour {
	public GameObject Crash;
	private int CEneCount;
	private bool creon;

	// Use this for initialization
	void Start () {
		CEneCount = 2;
		creon = true;
		Create();
	}
	
	// Update is called once per frame
	void Update () {
		if (Wave.enecount == 0 && creon == true)
		{
			creon = false;
			CEneCount++;
			Create();
			creon = true;
		}
	}

    void Create()
	{
		for (int i = 0; i < CEneCount; i++)
        {
            float xc = Random.Range(-49f, 49f);
            float yc = 0.5f;
            float zc = 31f;
            Vector3 cposition = new Vector3(xc, yc, zc);
            //突進する敵を生成
            GameObject CraEneClone = Instantiate(Crash, cposition, Quaternion.Euler(0f, 180f, 0f));
            Wave.enecount++;
            /*
            //生成された敵の名前の変更
            string CraEneName = "Crash_Enemy" + (i + 1);
            CraEneClone.name = CraEneName;
            //生成された敵の名前の子オブジェクトを取得
            var CrashChild = GameObject.Find(CraEneName).transform;
            foreach (Transform child in CrashChild.transform)
            {
                string Crashstr = "CraChild" + (i + 1);
                child.name = Crashstr;
            }
            */
        }
	}
}
