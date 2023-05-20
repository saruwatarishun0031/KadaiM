using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManajer : MonoBehaviour
{

    [SerializeField] Text _pointText;

    public int point;

    //シングルトンパターン（簡易型、呼び出される）
    public static UIManajer Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    //シングルトン（ここまで）
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        _pointText.text = "score:"+ point.ToString();
    }
    public void AddPoint(int scoer)
    {
        point += scoer;
    }
}

