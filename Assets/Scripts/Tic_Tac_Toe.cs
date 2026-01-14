using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using UnityEngine.UIElements;
using System;
using UnityEngine.UI;

public class Tic_Tac_Toe : MonoBehaviour
{

    public GameObject Wbox1;
    public GameObject Dbox1;
    public GameObject Wbox2;
    public GameObject Dbox2;
    public GameObject Wbox3;
    public GameObject Dbox3;
    public GameObject Wbox4;
    public GameObject Dbox4;
    public GameObject Wbox5;
    public GameObject Dbox5;
    public GameObject Wbox6;
    public GameObject Dbox6;
    public GameObject Wbox7;
    public GameObject Dbox7;
    public GameObject Wbox8;
    public GameObject Dbox8;
    public GameObject Wbox9;
    public GameObject Dbox9;

    public GameObject choice1;
    public GameObject choice2;

    
    public GameObject dis;
    public Text Display;

    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;
    public GameObject box7;
    public GameObject box8;
    public GameObject box9;

    string[] Choice = { "S1","S2", "S1", "S2", "S1", "S2", "S1", "S2", "S1", "S2","S1" };
    int i = 0, b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0, b6 = 0, b7 = 0, b8 = 0, b9 = 0;
    int c = 0;
    int ranInt = 0;

    int[,] checkArray = { { 1, 2, 3 }, { 1, 4, 7 }, { 1, 5, 9 }, { 2, 5, 8}, { 3, 6, 9}, { 4, 5, 6 }, { 1, 5, 9 }, { 3, 5, 7 } };
    
    List<int> xVal = new List<int> {};
    List<int> oVal = new List<int> {};


    public GameObject o1;
    public GameObject o2;
    public GameObject o3;

    public AudioSource pop;
    public AudioSource win;

    void Start()
    {
        // To choose the color to start First
        ranInt = UnityEngine.Random.Range(0, 2);
        if(ranInt == 0)
        {
            i++;
            choice2.SetActive(true);
            choice1.SetActive(false);
        }
        else
        {
            choice1.SetActive(true);
            choice2.SetActive(false);
        }
        
    }

    void Update()
    {
        // For Count 3
        Three();

        // For Count 4
        Four();
        
        // For Count 5
        Five();

        // for Draw Match
        if( c == 9)
        {
            disclose();
            dis.SetActive(true);
        }


    }


    void firework()
    {
        o1.SetActive(true);
        o2.SetActive(true);
        o3.SetActive(true);
    }

    void disclose()
    {
        box1.SetActive(false);
        box2.SetActive(false);
        box3.SetActive(false);
        box4.SetActive(false);
        box5.SetActive(false);
        box6.SetActive(false);
        box7.SetActive(false);
        box8.SetActive(false);
        box9.SetActive(false);

        choice1.SetActive(false);
        choice2.SetActive(false);
    }

    void Three()
    {
        if (xVal.Count == 3 || oVal.Count == 3)
        {
            xVal.Sort();
            oVal.Sort();
            for (int i = 0; i < checkArray.GetLength(0); i++)
            {
                int[] winPattern = new int[3];
                for (int c = 0; c < 3; c++)
                {
                    winPattern[c] = checkArray[i, c];
                }

                if (winPattern.All(xVal.Contains))
                {
                    disclose();
                    dis.SetActive(true);
                    Display.GetComponent<Text>().text = "Black Wins";
                    firework();
                    win.Play();
                }

                if (winPattern.All(oVal.Contains))
                {
                    disclose();
                    dis.SetActive(true);
                    Display.GetComponent<Text>().text = "White Wins";
                    firework();
                    win.Play();
                }
            }
        }
    }

    void Four()
    {
        // for x values
        if (xVal.Count == 4)
        {
            xVal.Sort();
            int[] x1 = new int[3];
            int[] x2 = new int[3];
            for (int c = 0; c < 3; c++)
            {
                x1[c] = xVal[c];
                x2[c] = xVal[c + 1];
            }

            for (int i = 0; i < checkArray.GetLength(0); i++)
            {
                int[] winPattern = new int[3];
                for (int c = 0; c < 3; c++)
                {
                    winPattern[c] = checkArray[i, c];
                }

                if (winPattern.All(x1.Contains) || winPattern.All(x2.Contains))
                {
                    disclose();
                    dis.SetActive(true);
                    Display.GetComponent<Text>().text = "Black Wins";
                    firework();
                    win.Play();
                }
            }
        }
        // For O Values
        if (oVal.Count == 4)
        {
            oVal.Sort();
            int[] o1 = new int[3];
            int[] o2 = new int[3];
            for (int c = 0; c < 3; c++)
            {
                o1[c] = oVal[c];
                o2[c] = oVal[c + 1];
            }

            for (int i = 0; i < checkArray.GetLength(0); i++)
            {
                int[] winPattern = new int[3];
                for (int c = 0; c < 3; c++)
                {
                    winPattern[c] = checkArray[i, c];
                }

                if (winPattern.All(o1.Contains) || winPattern.All(o2.Contains))
                {
                    disclose();
                    dis.SetActive(true);
                    Display.GetComponent<Text>().text = "White Wins";
                    firework();
                    win.Play();
                }
            }
        }
    }

    void Five()
    {
        // for x values
        if (xVal.Count == 5)
        {
            xVal.Sort();
            int[] x1 = new int[3];
            int[] x2 = new int[3];
            int[] x3 = new int[3];
            for (int c = 0; c < 3; c++)
            {
                x1[c] = xVal[c];
                x2[c] = xVal[c + 1];
                x3[c] = xVal[c + 2];
            }

            for (int i = 0; i < checkArray.GetLength(0); i++)
            {
                int[] winPattern = new int[3];
                for (int c = 0; c < 3; c++)
                {
                    winPattern[c] = checkArray[i, c];
                }

                if (winPattern.All(x1.Contains) || winPattern.All(x2.Contains) || winPattern.All(x3.Contains))
                {
                    disclose();
                    dis.SetActive(true);
                    Display.GetComponent<Text>().text = "Black Wins";
                    firework();
                    win.Play();
                }

            }
        }
        // For O Values
        if (oVal.Count == 5)
        {
            oVal.Sort();
            int[] o1 = new int[3];
            int[] o2 = new int[3];
            int[] o3 = new int[3];
            for (int c = 0; c < 3; c++)
            {
                o1[c] = oVal[c];
                o2[c] = oVal[c + 1];
                o3[c] = oVal[c + 2];
            }

            for (int i = 0; i < checkArray.GetLength(0); i++)
            {
                int[] winPattern = new int[3];
                for (int c = 0; c < 3; c++)
                {
                    winPattern[c] = checkArray[i, c];
                }

                if (winPattern.All(o1.Contains) || winPattern.All(o2.Contains) || winPattern.All(o2.Contains))
                {
                    disclose();
                    dis.SetActive(true);
                    Display.GetComponent<Text>().text = "White Wins";
                    firework();
                    win.Play();
                }
            }
        }
    }

    public void Box1()
    {
        c++;
        if(b1 ==0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox1.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox1.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b1++;

            if (i % 2 == 0)
            {
                xVal.Add(1);
            }
            else
            {
                oVal.Add(1);
            }

        }

    }
    public void Box2()
    {
        c++;
        if (b2 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox2.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox2.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b2++;
            if (i % 2 == 0)
            {
                xVal.Add(2);
            }
            else
            {
                oVal.Add(2);
            }
        }
    }
    public void Box3()
    {
        c++;
        if (b3 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox3.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox3.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b3++;
            if (i % 2 == 0)
            {
                xVal.Add(3);
            }
            else
            {
                oVal.Add(3);
            }
        }
    }
    public void Box4()
    {
        c++;
        if (b4 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox4.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox4.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b4++;
            if (i % 2 == 0)
            {
                xVal.Add(4);
            }
            else
            {
                oVal.Add(4);
            }
        }
    }
    public void Box5()
    {
        c++;
        if (b5 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox5.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox5.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b5++;
            if (i % 2 == 0)
            {
                xVal.Add(5);
            }
            else
            {
                oVal.Add(5);
            }
        }
    }
    public void Box6()
    {
        c++;
        if (b6 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox6.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox6.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b6++;
            if (i % 2 == 0)
            {
                xVal.Add(6);
            }
            else
            {
                oVal.Add(6);
            }
        }
    }
    public void Box7()
    {
        c++;
        if (b7 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox7.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox7.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b7++;
            if (i % 2 == 0)
            {
                xVal.Add(7);
            }
            else
            {
                oVal.Add(7);
            }
        }
    }
    public void Box8()
    {
        c++;
        if (b8 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox8.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox8.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b8++;

            if (i % 2 == 0)
            {
                xVal.Add(8);
            }
            else
            {
                oVal.Add(8);
            }
        }
    }
    public void Box9()
    {
        c++;
        if (b9 == 0)
        {
            pop.Play();
            if (Choice[i] == "S1")
            {
                Wbox9.SetActive(true);
                choice2.SetActive(true);
                choice1.SetActive(false);
            }
            else
            {
                Dbox9.SetActive(true);
                choice1.SetActive(true);
                choice2.SetActive(false);
            }
            i++;
            b9++;

            if (i % 2 == 0)
            {
                xVal.Add(9);
            }
            else
            {
                oVal.Add(9);
            }
        }
    }

    public void Restart()
    {
        pop.Play();
        Time.timeScale = .5f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("Refreshed...");
    }
}
