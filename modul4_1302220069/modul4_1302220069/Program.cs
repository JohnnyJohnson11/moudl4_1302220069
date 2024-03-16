// See https://aka.ms/new-console-template for more information

public class KodeBuah
{
    public enum Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
    };
    
    public static string getKodeBuah(Buah buah)
    {
        string[] kode = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        return kode[(int)buah];
    }
}
public class PosisiKarakterGame
{
    //1302220069%3=1
    
    public enum CharacterState
    {
        Tengkurap, Jongkok, Berdiri, Terbang
    }
    private CharacterState currentState;
    public PosisiKarakterGame()
    {
        currentState = CharacterState.Berdiri;
        Console.WriteLine("posisi standby");
    }
    public void klikW()
    {
        if (currentState==CharacterState.Tengkurap) 
        {
            currentState = CharacterState.Jongkok;
        } else if (currentState == CharacterState.Jongkok)
        {
            currentState = CharacterState.Berdiri;
            Console.WriteLine("posisi standby");
        } else if (currentState == CharacterState.Berdiri)
        {
            currentState = CharacterState.Terbang;
        }
    }
    public void klikS()
    {
        if (currentState == CharacterState.Terbang)
        {
            currentState = CharacterState.Berdiri;
            Console.WriteLine("posisi standby");
        }
        else if (currentState == CharacterState.Berdiri)
        {
            currentState = CharacterState.Jongkok;
        }
        else if (currentState == CharacterState.Jongkok)
        {
            currentState = CharacterState.Tengkurap;
            Console.WriteLine("posisi istirahat");
        }
    }
    public void klikX()
    {
        if (currentState == CharacterState.Terbang)
        {
            currentState = CharacterState.Jongkok;
        }
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(1302220069 % 3);
        KodeBuah kodeBuah= new KodeBuah();
        Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.Buah.Blackberry));
        PosisiKarakterGame posisiKarakterGame=new PosisiKarakterGame();
        string input=Console.ReadLine();
        while (input != "0") { 
            if (input == "W")
            {
                posisiKarakterGame.klikW();
            } else if (input == "S")
            {
                posisiKarakterGame.klikS();
            } else if (input == "X")
            {
                posisiKarakterGame.klikX();
            }
            input = Console.ReadLine();
        }
    }
}