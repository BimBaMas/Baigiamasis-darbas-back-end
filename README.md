# Baigiamasis darbas back-end
  
Žmogaus užregistravimo sistema  
  
User informacija:Username, Password, Role  
Žmogaus informacija:Vardas, Pavardė, Asmens kodas, Telefono numeris, El. paštas, Profilio nuotrauka, Gyvenamoji vieta  
Gyvenamoji vieta:Miestas, Gatvė, Namo numeris, Buto numeris 
  
Eiga:  
Vartotojas turi galėti užsiregistruoti.  
Useris turi galėti sukelti apie save informaciją, kurioje VISI laukai privalomi(Žmogaus informacija)  
Vartotojas neturi galėti sukelti informacijos apie daugiau nei vieną žmogų.  
Turi būti skirtingi endpoint atnaujint KIEKVIENĄ iš laukų, pvz.: Vardą, asmens kodą, telefono numerį, miestą(negalima atnaujinti į tuščią lauką arba whitespace)  
Registruojant žmogų turi būti privaloma įkelti profilio nuotrauką, jos dydis turi būti sumažintas iki 200x200(jeigu nuotrauka per maža tai ją ištemps iki 200x200)  
Turi būti galimybė gauti visą informaciją apie įkeltą žmogų pagal jo ID(nuotrauka grąžinama byte masyvu).  
Taip pat turi būti 'Admin' rolė, kuri bus nustatoma per duomenų bazę ir ji turės endpoint'ą per kurį galės ištrinti user'į pagal ID(ištrinant user’į ištrinam ir žmogaus info)  
Neprisijungus turi būti galima tik registruotis ir prisijungti  
Naudojama Mssql duomenų bazė.  
Naudojamas Entity Framework.
