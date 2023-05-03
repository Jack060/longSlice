# Larghest Series Product

Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.

## Ad esempio:

- data in ingresso la stringa "1027839564", 
- il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)
- e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).
- Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

<details>
  <summary>controllo che lo span sia corretto:</summary>
  
  ```c#
    if (span > digits.Length){
        throw new System.ArgumentException();
    }
    if (span == 0){
        return 1;
    }
    if (span < 0){
        throw new System.ArgumentException();
    }
                  
    char[] caratteri = digits.ToCharArray();
  ```
Qui controlliamo che in caso span sia maggiore della lunghezza del numero (digits) oppure minore di 0 mandi un errore, invece nel caso sia span uguale a 0 ritorna 1, altrimenti se passa questi requisiti il compilatore va avanti nel codice.
                  
</details>

<details>
  <summary>controllo numero (digits):</summary>
  
```c#
    for (int i = 0; i < digits.Length; i++)
      {
        if(char.IsLetter(caratteri[i])
          {
            throw new System.ArgumentException();                
          }
      }
 ```
In questa porzione di codice entriamo in un for utilizzato per scorrere il vettore (creato sopra) e controllare che in ogni posizione non ci sia una lettera, in caso ci sia invia un errore, invece se non c è nessuna lettera il compilatore continua a compilare il codice.

</details>
  
<details>
  <summary>calcolo prodotto:</summary>
  
```c#
    for (int j = 0; j <= digits.Length-span; j++)
    {
      int prod = 1;
      int supporto = j;

      for (int y = 0; y < span; y++)
        {
           prod = prod * (caratteri[supporto]-48);
           supporto = supporto + 1;
            }
            if(prod > max)
              {
                max = prod;
              }
        }
    }
    return max;
 ```
In questo ultimo punto vediamo come ricercare il prodotto (prod) maggiore che si possa formare nel numero e infine facciamo ritornare il prodotto 
</details>
