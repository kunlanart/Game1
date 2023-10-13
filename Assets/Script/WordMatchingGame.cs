using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WordMatchingGame : MonoBehaviour
{
    private Button firstButton; // ปุ่มคำศัพท์ที่เลือกครั้งแรก
    private bool isMatching = false; // กำลังจับคู่คำศัพท์และคำแปล

    public List<string> words = new List<string>(); // รายการคำศัพท์
    public List<string> translations = new List<string>(); // รายการคำแปล

    // เมื่อปุ่มถูกคลิก
    public void OnButtonClick(Button button)
    {
        if (!isMatching)
        {
            firstButton = button;
            isMatching = true;
        }
        else
        {
            // คลิกปุ่มคำแปล
            if (words.Contains(firstButton.GetComponentInChildren<Text>().text))
            {
                string translation = translations[words.IndexOf(firstButton.GetComponentInChildren<Text>().text)];
                if (translation == button.GetComponentInChildren<Text>().text)
                {
                    // คำศัพท์และคำแปลตรงกัน
                    // ทำอะไรสิ่งที่คุณต้องการ เช่น ลบปุ่มหรือแสดงข้อความชนะเกม
                    Debug.Log("คำศัพท์และคำแปลตรงกัน!");
                    firstButton.gameObject.SetActive(false);
                    button.gameObject.SetActive(false);
                }
                else
                {
                    // คำศัพท์และคำแปลไม่ตรงกัน
                    // ทำอะไรสิ่งที่คุณต้องการ เช่น รีเซ็ตเกม
                    Debug.Log("คำศัพท์และคำแปลไม่ตรงกัน!");
                }
            }

            firstButton = null;
            isMatching = false;
        }
    }
    public List<string> words = new List<string>()
    {
        "garbage", "traffic", "exit", "valuable", "situation", "astronaut",
        "teaspoon", "palace", "opposite"
    };

    public List<string> translations = new List<string>()
    {
        "ขยะ", "การจราจร", "ทางออก", "มีคุณค่า", "สถานการณ์", "นักบินอวกาศ",
        "ช้อนชา", "พระราชวัง", "ตรงกันข้าม"
    };
}
