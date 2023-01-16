using System.Collections.Generic;
using System;

class fordon{
    private string tillverkare;
    private string bilmodel;
    private int år;
    private int vikt;

// änvända set get metoder
    public void SetTill(string t) {tillverkare=t;}
     public string GetTill() {return tillverkare;}
      public void SetTBil(string b) {bilmodel= b;}
     public string GetBil() {return bilmodel;}
      public void SetÅr(int å) {år=å;}
     public int  GetÅr() {return år;}
      public void SetVikt(int v) {vikt=v;}
     public int GetVikt() {return vikt;}
}

class program{
    public static void Main(){
     // skapa lista för att kunna lägga eller ta bort objekt

    List <fordon> list= new List<fordon>();
      fordon f= new fordon();
        f.SetTill("Jeff 1");
        f.SetTBil("BMW Z");
        f.SetÅr(2018);
        f.SetVikt(675);
        list.Add(f);

        fordon r= new fordon();
        r.SetTill("Jeff 3");
        r.SetTBil("Benz C");
        r.SetÅr(2005);
        r.SetVikt(785);
        list.Add(r);

        fordon l= new fordon();
        l.SetTill("r");
        l.SetTBil("gg");
        l.SetÅr(555);
        l.SetVikt (58958);
        list.Add(l);

        // använda foreach för att sktiva ut attributen av alla objekt
        foreach(fordon element in list){
          Console.WriteLine(element.GetTill());
           Console.WriteLine(element.GetBil());
           Console.WriteLine(element.GetÅr());
           Console.WriteLine(element.GetVikt());
           // addera space mellan varje grupp
           Console.WriteLine(" ");
        }
    }
    }             
