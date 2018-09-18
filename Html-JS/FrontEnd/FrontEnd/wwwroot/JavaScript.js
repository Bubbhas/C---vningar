funExtra2()
// andra delen tisdag
function funExtra2() {
    function beräknaMoms(vara, price) {
        if (vara === "tidning" || vara === "flyg")
            return price*0.06
        else if (vara === "restaurangbesök")
            return price * 0.12
        else if (vara === "falafel" || vara === "hipsteröl")
            return price * 0.25

    }
    function skrivUtProduktInfo(sak, price){
        return console.log("Momsen för en/ett" + sak +" är " + beräknaMoms(sak, price)+ "kr");
    }

    skrivUtProduktInfo("tidning", 1000);
    skrivUtProduktInfo("restaurangbesök", 1000);
    skrivUtProduktInfo("flyg", 1000);
    skrivUtProduktInfo("falafel", 1000);
    skrivUtProduktInfo("hipsteröl", 1000);
}

function funExtra1() {
    function timeUntilRetirement(tal) {
        if (tal <= 65)
            return 65 - tal
        else 
            return 0
    }

    console.log(`Antal år till pension: ${timeUntilRetirement(43)}`);
    console.log(`Antal år till pension: ${timeUntilRetirement(20)}`);
    console.log(`Antal år till pension: ${timeUntilRetirement(68)}`);
    console.log(`Antal år till pension: ${timeUntilRetirement(100)}`);
}

function funret5() {
    function isMyndig(age) {
        if (age > 15)
            return true
        else 
            return false
    }
    let susansAge = 13;
    let myndig = isMyndig(susansAge);
    if (myndig == true) {
        console.log("Susan är myndig");
    } else {
        console.log("Susan är INTE myndig");
    }
}

function funret4() {
    function addNumbers(tal, tal2) {
        return tal + tal2
    }
    let summa = addNumbers(3, 4);
    console.log(summa);
}

function funret3() {
    function laggTillTusen(sak) {
        return sak+1000
    }
    let mittNummer = laggTillTusen(18);
    console.log(mittNummer);
}

function funret2() {
    function superImportant(sak, sak2) {
        if (sak2)
            return `***** ${sak.toUpperCase()} *****`
        else
            return `***** ${sak} *****`
    }
    console.log(superImportant("Service now", true));
    console.log(superImportant("Service now", false));
    console.log(superImportant("What does the fox says?", false));
    console.log(superImportant("What does the fox says?", true));
}

function funret1() {
    function superImportant(sak) {
        return `***** ${sak.toUpperCase()} *****`
    }
    let text = superImportant("Itch");
    console.log(text);
}


//Ny del tisdag
function extraFun4() {
    skrivUtMoms2("en", "tidning", 1000);
    skrivUtMoms2("ett", "restaurangbesök", 1000);
    skrivUtMoms2("ett", "flyg", 1000);
    skrivUtMoms2("en", "falafel", 1000);
    skrivUtMoms2("en", "hipsteröl", 1000);

    function skrivUtMoms2(sak, vara, price) {
        if (vara === "tidning" || vara === "flyg")
            console.log(`Momsen för ${sak} ${vara} som kostar ${price} är ${price * 0.06}`)
        else if (vara === "restaurangbesök")
            console.log(`Momsen för ${sak} ${vara} som kostar ${price} är ${price * 0.12}`)
        else if (vara === "falafel" || vara === "hipsteröl")
            console.log(`Momsen för ${sak} ${vara} som kostar ${price} är ${price * 0.25}`)

    };
}

function extraFun3() {
    skrivUtMoms2("tidning", 1000);
    skrivUtMoms2("restaurangbesök", 1000);
    skrivUtMoms2("flyg", 1000);
    skrivUtMoms2("falafel", 1000);
    skrivUtMoms2("hipsteröl", 1000);

    function skrivUtMoms2(vara, price) {
        if (vara === "tidning" || vara === "flyg")
            console.log(`Momsen för en/ett ${vara} som kostar ${price} är ${price * 0.06}`)
        else if (vara === "restaurangbesök")
            console.log(`Momsen för en/ett ${vara} som kostar ${price} är ${price * 0.12}`)
        else if (vara === "falafel" || vara === "hipsteröl")
            console.log(`Momsen för en/ett ${vara} som kostar ${price} är ${price * 0.25}`)

    };
}

function extraFun2() {
    recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
    recept("Rotmos", ["Potatis", "Kålrot"]);

    function recept(maträtt, ingredience) {
        console.log(`För att göra ${maträtt} behövs`.toUpperCase());
        for (let p of ingredience) {
            console.log("* " + p.toUpperCase())
        }

    };
}

function extraFun1() {
    inkopslista(["skruv", "hammare", "Vattenpass"]);
    inkopslista(["Penna", "Luktsuddigum"]);

    function inkopslista(stuff) {
        console.log("ATT KÖPA:");
        for (let p of stuff) {
            console.log("* " + p)
        }

    };
}


function fun4() {
    skrivUtMoms(1000);

    function skrivUtMoms(price) {
        console.log(price * 0.25 + "kr")

    };
}

function fun3() {
    myndig("Peter", 16)
    myndig("Lisa", 26)
    myndig("Ragnar", 15)

    function myndig(namn, år) {
        if (år < 20) {
            console.log(`Obs! ${namn} är inte myndig`)
        } else {
            console.log(`${namn} är mynidg`)
        };

    };
}

function fun2() {
    sayhiTo("jesper");

    function sayhiTo(namn) {
        console.log("-".repeat(7))
        console.log("-".repeat(7) + "VÄLKOMMEN " + namn.toUpperCase())
        console.log("-".repeat(7))

    };
}


function fun1() {
    sayhi();
    sayhi();
    function sayhi() {
        console.log("-".repeat(7))
        console.log("-".repeat(7) + "VÄLKOMMEN")
        console.log("-".repeat(7))

    };
}










function obj4() {
    let paintings = [{
        namn: "bla",
        konstnär: "jesper",
        år: 1993
    }
        , {
        namn: "habl",
        konstnär: "kurt",
        år: 2003
    }, {
        namn: "plaaaa",
        konstnär: "simon",
        år: 2010
    }];
    let skriet = {
        namn: "Skriet",
        konstnär: "Edvard Munch",
        År: 1893
    };
    paintings.push(skriet);
    console.log(paintings[3].År);
    paintings.pop();
    paintings.pop();
    paintings.pop();
    console.log(paintings.length);
}

function obj3() {
    let paintings = [{
        namn: "bla",
        konstnär: "jesper",
        år: 1993
    }
        , {
        namn: "habl",
        konstnär: "kurt",
        år: 2003
    }, {
        namn: "plaaaa",
        konstnär: "simon",
        år: 2010
    }]
    console.log(`Det finns ${paintings.length} antal målningar`);
    console.log(`${paintings[1].konstnär} målade ${paintings[1].namn} år ${paintings[1].år}`);
    for (let a of paintings) {
        console.log(a.konstnär + a.namn + a.år)
    }
}

function obj2() {
    let person = {
        förnamn: "Jesper",
        efternamn: "Eriksson",
        Födelseår: 1993,
        Rollkaraktär: ['percy nilegård', 'farbror barbro'],
        adressuppgfiter: {
            street: "musse",
            city: "Stockholm",
            country: "Sweden"
        }
    }
    console.log(person.förnamn + " är född " + person.Födelseår)
    console.log(`${person.förnamn} bor på gatan ${person.adressuppgfiter.street}`)
    console.log(`${person.förnamn} har spelar ${person.Rollkaraktär.length} roller bland annat ${person.Rollkaraktär[1]} `)
}

function obj1() {
    let person = {
        förnamn: "Jesper",
        efternamn: "Eriksson",
        Födelseår: 1993
    }
    console.log(person.förnamn + " " + person.efternamn)
}

let book = {
    title: "Röda rummet",
    author: {
        firstName: "August",
        lastName: "Strindberg"
    }
}

//Fjärde delen
function cond9() {
    let a = 13 * 13
    let b = 169
    let result = a === 169 ? 'lika' : 'olika';

    console.log(result);
}


function cond8() {
    if (3 == "3")
        console.log("japp")

    if (2 === "2")
        console.log("happ")
}

function cond7() {
    let favouriteVegatable = "kålrot"
    let answer;
    switch (favouriteVegatable) {
        case "kålrot": answer = "hejsan"; break;
        case "majrova": answer = "nej"; break;
        default: console.log("nemaso");

    }
    console.log(answer);
}

function cond6() {
    let favouriteVegatable = "majrova"
    switch (favouriteVegatable) {
        case "kålrot": console.log("heeej"); break;
        case ("majrova"): console.log("passar till falafel"); break;
        default: console.log("nemaso");
    }
}

function cond5() {
    let shoeMaria = 42
    let shoeAli = 42
    let bigFoot = 49
    if (bigFoot > 50 || bigFoot > 50 || shoeMaria > 50) {
        console.log("heeey")
    } else
        console.log("buu")
}

function cond4() {
    let shoeMaria = 42
    let shoeAli = 42
    let bigFoot = 52
    if (bigFoot > shoeAli && bigFoot > shoeMaria) {
        console.log("heeey")
    } else
        console.log("buu")
}

function cond3() {
    let shoeMaria = 42
    let shoeAli = 42
    if (shoeMaria === shoeAli) {
        console.log("heeey")
    } else
        console.log("buu")
}


function cond2() {
    let shoeMaria = 362
    let shoeAli = 42
    if (shoeMaria < shoeAli) {
        console.log("heeey")
    } else
        console.log("buu")
}

function cond1() {
    let shoeMaria = 42
    let shoeAli = 42
    if (shoeMaria === shoeAli) {
        console.log("heeey")
    }
    //let fruit = "banan"
    //let x1 = fruit === "banan" || fruit === "päron";
}


function loop7() {
    let importentYears = [1492, 1789, 1859, 1929]
    let i = 1;
    for (let o of importentYears) {
        if (o > 1800) {
            break;
        }
        console.log(i + ": " + o);
        i++;
    }
}


function loop6() {
    let importentYears = [1492, 1789, 1859, 1929]
    let i = 1;
    for (let o of importentYears) {
        console.log(i + ": " + o);
        i++;
    }
}

function loop5() {
    let importentYears = [1492, 1789, 1859, 1929]
    for (let o of importentYears) {
        console.log(o);
    }
}

function loop4() {
    let i = 4;
    while (i > 3 && i < 9) {
        console.log(`Siffran ${i} är tjusig`)
        i++;
    }
}


function loop3() {
    for (var i = 4; i <= 8; i++) {
        console.log(`Siffran ${i} är tjusig`)
    }
}

function loop2() {
    for (var i = 0; i <= 9; i++) {
        console.log(i)
    }
}

function loop1() {
    for (var i = 5; i <= 18; i++) {
        console.log(i)
    }
}