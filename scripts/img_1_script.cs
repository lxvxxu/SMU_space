using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class img_1_script : MonoBehaviour
{
    //N201
    public Sprite change_img;
    public Sprite change_img_R;
    Image thisImg;
    int my_h = 0;


    // �����ð� 1���� ��ũ��Ʈ //
    public int num_1 = 0;
    public int num_2 = 0;




    // Start is called before the first frame update
    void Start()
    {
        my_h = GameObject.Find("script").GetComponent<FIN_TIME>().fin_hour;

        thisImg = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (my_h >= num_1 && my_h < num_2)
            ChangeImage_B();
        else
            ChangeImage_R();
    }

    public void ChangeImage_B()
    {
        thisImg.sprite = change_img;
    }
    public void ChangeImage_R()
    {
        thisImg.sprite = change_img_R;
    }


}
