import Foundation
//Zad.1 - Drugie największe w tablicy
let l = [2, 5, 8, 1, 3]
let sortowanie = l.sorted(by: >)
let vicemax = sortowanie[1]
print(vicemax)

//Zad.2 - Sprawdź, czy liczba jest pierwiastkowalna
func czyPierwiastek(n: Int) -> Bool{
    let p = sqrt(Double(n))
    let pzaokr = Int(p)
    let k = pzaokr * pzaokr 
    if (k == n) {
        return true
    }
    return false
}
print(czyPierwiastek(n: 16))

//Zad.3 - Najdłuższy ciąg rosnący w tablicy
