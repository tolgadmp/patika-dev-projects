# algorithm-and-data-structures  
## Proje 1 InsertionSort:  
[22,27,16,2,18,6] -> Insertion Sort

Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.  
Big-O gösterimini yazınız.
Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.
Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.  

Adım 1: 22 27 16 2 18 6  
Adım 2: 16 22 27 2 18 6  
Adım 3: 2 16 22 27 18 6  
Adım 4: 2 16 18 22 27 6  
Adım 5: 2 6 16 18 22 27  

Big O = O(n^2)  
BestCase = O(1)  
AvatageCase = O(n^2)  
WorstCase = O(n^2)  

18 AvarageCase kapsamına girer.  

[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.  

Adım 1: 3 7 5 8 2 9 4 15 6  
Adım 2: 3 5 7 8 2 9 4 15 6  
Adım 3: 3 5 7 8 2 9 4 15 6  
Adım 4: 2 3 5 7 8 9 4 15 6  

## Proje 2 MergeSort:
[16,21,11,8,12,22] -> Merge Sort  

Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.  
Big-O gösterimini yazınız.  

Adım 1: 16,21,11 | 8,12,22  
Adım 2: 16,21 | 11 | 8,12 | 22  
Adım 3: 16 | 21 | 11 | 8 | 12 | 22  
Adım 4: 16,21 | 8,11 | 12,22  
Adım 5: 8,11,16,22 | 12,22  
Adım 6: 8,11,12,16,22  

Big O = O(n log(n))  

## Proje 3 Binary Seacrh Tree:  
[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.  

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.  

Adım 1: root 7 dir.  
Adım 2: root 7 dir. Solunda 5 bulunur.  
Adım 3: root 7 dir. Solunda 1 bulunur. 1' in solunda 5 bulunur.  
Adım 4: root 7 dir. Solunda 1 bulunur. 1' in solunda 5 bulunur. 7 nin sağında 8 bulunur.  
Adım 5: root 7 dir. Solunda 1 bulunur. 1' in solunda 5 bulunur, sağında 3 bulunur. 7 nin sağında 8 bulunur.  
Adım 6: root 7 dir. Solunda 5 sağında 8 bulunur. 5 in solunda 1 bulunur. 1 in solunda 0 sağında 3 bulunur.  
Adım 7: root 7 dir. Solunda 5 sağında 8 bulunur. 5 in solunda 1 sağında 6 bulunur. 1 in solunda 0 sağında 3 bulunur.  
Adım 8: root 7 dir. Solunda 5 sağında 8 bulunur. 5 in solunda 1 sağında 6 bulunur. 1 in solunda 0 sağında 3 bulunur. 8 in sağında 9 bulunur.  
Adım 9: root 7 dir. Solunda 5 sağında 8 bulunur. 5 in solunda 1 sağında 6 bulunur. 1 in solunda 0 sağında 3 bulunur. 3 ün sağında 4 bulunur. 8 in sağında 9 bulunur. Adım 10: root 7 dir. Solunda 5 sağında 8 bulunur. 5 in solunda 1 sağında 6 bulunur. 1 in solunda 0 sağında 3 bulunur. 3 ün sağında 4 solunda 2 bulunur. 8 in sağında 9 bulunur.
