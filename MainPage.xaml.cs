using Microsoft.Maui.Animations;
using System.Text;

namespace Anelli.Alessandro._3i.MAUIString;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    //Is Digit

    bool isdigit(char c)
    {
        if(!(isletter(c) || isnumber(c)))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    //IsNumber
    bool isnumber(char c)
    {
        if ((int)c >= '0' && (int)c <= '9')
        {
            return true;
        }
        else
        {
            return false;
        }
    }




    //IsLetter
    bool isletter(char c)
    {
        if (c >= 'a' && c <= 'z' || (c >= 'A' && c <= 'Z'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    //Lunghezza
    int Len(string s)
    {
        char[] caratteri = s.ToCharArray();
        int i = 0;

        foreach (var carattere in caratteri)
        {
            i++;
        }

        int lunghezza = i;

        return lunghezza;
    }

    //to upper
    char toupper(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            int a = (int)c & 0xDF;                              
            return (char)a;
        }
        return c;
    }

    //to lower
    char tolower(char c)
    {
        if (c >= 'A' && c <= 'Z')
        {
            int a = (int)c | 0x20;                             
            return (char)a;
        }
        return c;
    }



    //maiuscolo lab
    string Maiuscolo(string s)
    {
        char[] caratteri = s.ToCharArray();
        for (int i = 0; i < Len(s); i++)
        {
            caratteri[i] = toupper(caratteri[i]);                       
        }
        return new String(caratteri);

    }

    //Minuscolo
    string Minuscolo(string s)
    {
        char[] caratteri = s.ToCharArray();
        for (int i = 0; i < Len(s); i++)
        {
            caratteri[i] = tolower(caratteri[i]);                       
        }
        return new String(caratteri);

    }

    string capitalazied(string s)
    {
        char[] caratteri = s.ToCharArray();

        bool lettera;

        for (int i = 0; i < edtEditor.Text.Length; i++)
        {
            if (i == 0)
            {
                //if (isdigit(edtEditor.Text[i]))
                //{

                //}

                caratteri[i] = toupper(edtEditor.Text[i]);
            }
            else
            {
                if (edtEditor.Text[i - 1] == ' ' || edtEditor.Text[i] == ',' || edtEditor.Text[i] == '.' || edtEditor.Text[i] == '!' || edtEditor.Text[i] == '-' || edtEditor.Text[i] == '_')
                {
                    caratteri[i] = toupper(edtEditor.Text[i]);
                }
                else
                {
                    caratteri[i] = tolower(edtEditor.Text[i]);
                }
            }
        }

        return new String(caratteri);
    }


    private void OnCounterClicked(object sender, EventArgs e)
    {


        //txtMaiuscolo.Text

        txtMaiuscola.Text = Maiuscolo(edtEditor.Text);





        //txtMinuscolo.Text

        txtMinuscola.Text = Minuscolo(edtEditor.Text);

        //txtCapitalized.Text               3 frase



        txtCapitalized.Text = capitalazied(edtEditor.Text);



        //txtPalindroma.Text                4 frase


        bool palindromo = true;
        int j = Len(edtEditor.Text) - 1;
        for (int i = 0; i < Len(edtEditor.Text); i++)
        {
            if (edtEditor.Text[i] != edtEditor.Text[j])
            {
                palindromo = false;
            }

            j--;

        }

        if (palindromo)
        {
            txtPalindroma.Text = "si";
        }
        else
        {
            txtPalindroma.Text = "no";
        }



        //txtReverse.Text                   5 frase

        txtReverse.Text = "";
        for (int i = Len(edtEditor.Text) - 1; i >= 0; i--)
        {
            txtReverse.Text = txtReverse.Text + edtEditor.Text[i];
        }



        //txtNumParola.Text                 6 frase

        char vuoto = ' ';
        int count = 0;
        string input;

        input = edtEditor.Text.Trim();    // da terminare

        for (int i = 0; i < Len(input); i++)
        {

            if (input[i] == vuoto)
            {
                if (input[i - 1] != vuoto)
                {
                    count++;
                }
            }
        }

        count++;

        txtNumParole.Text = count.ToString();



        //txtNumLettere.Text                7 frase

        int conta = 0;
        for (int i = 0; i < Len(input); i++)
        {
            if (input[i] != vuoto)

            {
                conta++;
            }
        }

        txtNumLettere.Text = conta.ToString();



        //txt.Alfanumerici.Text                8 frase

        bool alfanumerico = true;
        for (int i = 0; i < Len(input); i++)
        {
            if (!(isletter(edtEditor.Text[i]) || isnumber(edtEditor.Text[i])))
            {
                alfanumerico = false;
            }

        }

        if (alfanumerico)
        {
            txtAlfanumerici.Text = "si";
        }
        else
        {
            txtAlfanumerici.Text = "no";
        }

        //txt.Alfabetico.Text                 9 frase  

        bool Alfabetico = true;
        for (int i = 0; i < Len(input); i++)
        {
            if (!(isletter(edtEditor.Text[i])))
            {
                Alfabetico = false;
            }

        }

        if (Alfabetico)
        {
            txtAlfabetico.Text = "si";
        }
        else
        {
            txtAlfabetico.Text = "no";
        }















    }
}
