using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Icon_button : MonoBehaviour
{

    public GameObject Unlock_Effect7, Unlock_Effect8, Unlock_Effect9; 
    //����Ʈ�� ĳ���͸��� �޶��� �� �� ������ ��������(����Ʈ�� ��������Ʈ�ϼ���, Ȥ�� ����Ʈ(��ƼŬ)�� �� �� �ִ�~

    
    public Text Point_Check;        //����Ʈ ( ȭ�鿡 ǥ���� ����Ʈ : â �ҷ�����)
    int point = 10;                 //����Ʈ ( �⺻ 10����Ʈ. ����� �ʿ� ����Ʈ 3)

    //������ �迭�� ���� �������ѵ�... 
    public Toggle Bicon1, Bicon2, Bicon3, Bicon4, Bicon5, Bicon6, Bicon7, Bicon8, Bicon9;
    public Toggle B_Bicon1, B_Bicon2, B_Bicon3, B_Bicon4, B_Bicon5, B_Bicon6, B_Bicon7, B_Bicon8, B_Bicon9;
    public Button Unlock_Button;
    public GameObject BiconNoneIntel, Bicon1Intel, Bicon2Intel, Bicon3Intel, Bicon4Intel, Bicon5Intel,
        Bicon6Intel, Bicon7Intel, Bicon8Intel, Bicon9Intel;

    private bool checkbuttonClick = false;      //������ ���� ���� �ϴ� �ر� ��ư�� ���� �� ������ ��ư ������ �ƴ��� Ȯ�� ����
    private int Icon_discernment = 0;           //�������� ������ �ش� �����ܿ� ���ڰ� ������. ����&&����Ʈ ������ ��� �̷������� ����


    public void Start()
    {
        Point_Check.text = "����Ʈ :" + point;    //ȭ�� ���� ��ܿ� ����Ʈâ(�ӽ�)
    }

    public void ForCheck1()
    {        //1~9 �� ���̸� �� ��ġ���� ���� �ο�.
        if (B_Bicon1.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon1.isOn) Icon_discernment = 1;
            Debug.Log("1");
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon1.isOn) Icon_discernment = 0;        //���ڸ� 0�� �༭ ����Ʈ �����ص� ��� �ȵǵ���
            Debug.Log("1-0");
        }
    }
    public void ForCheck2() 
    { 
        if (B_Bicon2.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon2.isOn) Icon_discernment = 1;
            Debug.Log("2");
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon2.isOn) Icon_discernment = 0;
            Debug.Log("2-0");
        }
    }
    public void ForCheck3()
    {
        if (B_Bicon3.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon3.isOn) Icon_discernment = 1;
            Debug.Log("3");
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon3.isOn) Icon_discernment = 0;
            Debug.Log("3-0");
        }
    }
    public void ForCheck4()
    {
        if (B_Bicon4.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon4.isOn) Icon_discernment = 1;
            Debug.Log("4");
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon4.isOn) Icon_discernment = 0;
            Debug.Log("4-0");
        }
    }
    public void ForCheck5()
    {
        if (B_Bicon5.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon5.isOn) Icon_discernment = 1;
            Debug.Log("5");
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon5.isOn) Icon_discernment = 0;
            Debug.Log("5-0");
        }
    }
    public void ForCheck6()
    {
        if (B_Bicon6.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon6.isOn) Icon_discernment = 1;
            Debug.Log("6");
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon6.isOn) Icon_discernment = 0;
            Debug.Log("6-0");
        }
    }
    public void ForCheck7(){        //1~9 �� ���̸� �� ��ġ���� ���� �ο�.
        if (B_Bicon7.isOn){
            checkbuttonClick = true;
            if (B_Bicon7.isOn) Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //��� �ȵǾ������� ������ ����â ���� ���� ����
            Debug.Log("7");
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon7.isOn) Icon_discernment = 0;        //���ڸ� 0�� �༭ ����Ʈ �����ص� ��� �ȵǵ���
            Debug.Log("7-0");
        }
    }
    public void ForCheck8(){
        if (B_Bicon8.isOn){
            checkbuttonClick = true;
            if (B_Bicon8.isOn) Icon_discernment = 8;
            Debug.Log("8");
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon8.isOn) Icon_discernment = 0;
            Debug.Log("8-0");
        }
    }
    public void ForCheck9(){
        if (B_Bicon9.isOn){
            checkbuttonClick = true;
            if (B_Bicon9.isOn) Icon_discernment = 9;
            Debug.Log("9");
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon9.isOn) Icon_discernment = 0;
            Debug.Log("9-0");
        }
    }



    public void Unlock_ButtonPress()        //���� ForCheck[] ���� �ο����� ���ڷ� �رݹ�ư Ȱ��ȭ
    {

        switch (Icon_discernment)
        {

            // 1~3�� �� ���� 1 2 3
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;

                //4~5�� ������� 4 5 6
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
                // 7~ 9�� �� �Ʒ���  7 8 9
            case 7:
                if (checkbuttonClick == true && point > 3)
                {
                    B_Bicon7.gameObject.SetActive(false);
                    Bicon7.gameObject.SetActive(true);
                    Unlock_Effect7.SetActive(true);
                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                }
                else
                {
                    Debug.Log("����Ʈ����");
                    return;
                }
                break;

            case 8:
                if (checkbuttonClick == true && point > 3)
                {
                    B_Bicon8.gameObject.SetActive(false);
                    Bicon8.gameObject.SetActive(true);
                    Unlock_Effect8.SetActive(true);
                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                }
                else
                {
                    Debug.Log("����Ʈ����");
                    return;
                }
                break;

            case 9:
                if (checkbuttonClick == true && point > 3)
                {
                    B_Bicon9.gameObject.SetActive(false);
                    Bicon9.gameObject.SetActive(true);
                    Unlock_Effect9.SetActive(true);
                    point = point - 3;
                    Point_Check.text = "����Ʈ :" + point;
                }
                else
                {
                    Debug.Log("����Ʈ����");
                    return;
                }
                break;
        }

    }




    //public void BiconToggle7Click()
    //{

    //    if (Bicon7.isOn)
    //    {
    //        Bicon7Intel.gameObject.SetActive(true);
    //    }
    //    else
    //    {
    //        Bicon7Intel.gameObject.SetActive(false);
    //    }
    //}



    //IEnumerable WaitForDis()
    //{
    //    Unlock_Effect.SetActive(true);
    //    Debug.Log("Ezplode Enter");
    //    yield return new WaitForSeconds(2.0f);
    //    Bicon7.gameObject.SetActive(false);
    //    Debug.Log("Ezplode end");
    //}


    //Vector3 spawn = this.gameObject.transform.localPosition;
    //spawn.z = Unlock_Effect.gameObject.transform.localPosition.z;
    //Instantiate(Unlock_Effect, spawn, Quaternion.identity);

}
