import Foundation
//Zad.1 - Drugie największe w tablicy
var l = [2, 5, 8, 1, 3]
var sortowanie = l.sorted(by: >)
var vicemax = sortowanie[1]
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
func najdluzszyCiag(tab: [Int]) -> [Int]{
    var najciag: [Int] = []
    var t: [Int] = [tab[0]]
    for i in 1..<tab.count{
        if tab[i] > tab[i-1]{
            t.append(tab[i])
        }
        else{
            if t.count > najciag.count{
                najciag = t
            }
            t = [tab[i]]
        }
    }
    return najciag
}
var tab = [1, 2, 3, 2, 5, 6, 7, 1]
print(najdluzszyCiag(tab: tab))
