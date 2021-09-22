using System;

namespace zufallsgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int attemt = 0;
            int guess = 0;


            string titel = @"
                                                                                                                                                 
                                                                                                                                                 
              :               ,;         .        .    L.                                                                                      ,;
          .Gt Ef            f#i         ;W       ;Wt   EW:        ,ft         .Gt               .Gt                                          f#i 
         j#W: E#t         .E#t         f#E      f#EEj  E##;       t#E        j#W:              j#W:            ..           ..       :     .E#t  
       ;K#f   E#t        i#W,        .E#f     .E#f E#, E###t      t#E      ;K#f              ;K#f             ;W,          ,W,     .Et    i#W,   
     .G#D.    E#t       L#D.        iWW;     iWW;  E#t E#fE#f     t#E    .G#D.             .G#D.             j##,         t##,    ,W#t   L#D.    
    j#K;      E#t fi  :K#Wfff;     L##Lffi  L##LffiE#t E#t D#G    t#E   j#K;              j#K;              G###,        L###,   j###t :K#Wfff;  
  ,K#f   ,GD; E#t L#j i##WLLLLt   tLLG##L  tLLG##L E#t E#t  f#E.  t#E ,K#f   ,GD;       ,K#f   ,GD;       :E####,      .E#j##,  G#fE#t i##WLLLLt 
   j#Wi   E#t E#t L#L  .E#L         ,W#i     ,W#i  E#t E#t   t#K: t#E  j#Wi   E#t        j#Wi   E#t      ;W#DG##,     ;WW; ##,:K#i E#t  .E#L     
    .G#D: E#t E#tf#E:    f#E:      j#E.     j#E.   E#t E#t    ;#W,t#E   .G#D: E#t         .G#D: E#t     j###DW##,    j#E.  ##f#W,  E#t    f#E:   
      ,K#fK#t E###f       ,WW;   .D#j     .D#j     E#t E#t     :K#D#E     ,K#fK#t           ,K#fK#t    G##i,,G##,  .D#L    ###K:   E#t     ,WW;  
        j###t E#K,         .D#; ,WK,     ,WK,      E#t E#t      .E##E       j###t             j###t  :K#K:   L##, :K#t     ##D.    E#t      .D#; 
         .G#t EL             tt EG.      EG.       E#t ..         G#E        .G#t              .G#t ;##D.    L##, ...      #G      ..         tt 
           ;; :                 ,        ,         ,;.             fE          ;;                ;; ,,,      .,,           j                     
                                                                    ,                                                                            
";

            Console.WriteLine(titel);
            Console.WriteLine("ich werde mir eine Zahl Von 1-100 ausdenken und Sie müssen diese Zahl erraten ^.^ ");
            Console.WriteLine("viel Glück");
            Console.ReadKey();
            Random myObject = new Random();
            int ranNum = myObject.Next(1, 100);
            
            
            while (guess != ranNum)
            {
                
                Console.Write("Zahl bitte hier eingeben (0-100) (~ ° w °)~: ");
                attemt++;
                try
                {
                    guess = int.Parse(Console.ReadLine());
                    if (guess == ranNum)
                    {

                        Console.WriteLine("Super! (^o^)/ \nSie haben " + attemt + " Versuche gebraucht");
                    }
                    else if (guess < ranNum)
                    {
                        Console.WriteLine("Eingabe zu klein ¦/ \n");
                    }
                    else if (guess > ranNum)
                    {
                        Console.WriteLine("Eingabe zu groß ¬.¬\"  \n");
                    }
                }
                
                catch
                {
                    Console.WriteLine("Fehlerhafte Eingabe (\" > O <)o \n");
                }
                

           
            }

        }
    }
}
