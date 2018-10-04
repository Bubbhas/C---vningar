const app = new Vue({
    el: "#lab4Andra",
    data: {
        allproducts: []
    },
    created: async function () {
        let response = await fetch("/products");

        if (response.status === 200) {
            this.allproducts = await response.json();
        }

        else {
            alert("FEL")
        }
    },
    methods: {
        addOne: function (p) {
            p.quantity++
        },
        subOne: function (p) {
            if (p.quantity > 0)
            p.quantity--
        },
        assertPositive: function (p) {
            if (p.quantity === "" || p.quantity === NaN)
                p.quantity = 0
            if (p.quantity < 0)
                p.quantity = 0
        },

    },
    computed: {
        allQ: function () {
            let allproductsQ = 0;
            let allt = this.allproducts
            for (let item of allt) {
                allproductsQ += parseInt(item.quantity)
            }
            return allproductsQ
        }
    }












    //el: "#app",
    //data: {
    //    counter: 0
    //},
    //computed: {
    //    text: function () {
    //        if (this.counter >= 10 && this.counter < 20)
    //            return "Du har tryckt massor medgånger"
    //        else if (this.counter >= 20)
    //            return "Du har tryckt över 20 ggr"
    //    }
    //}
    //el: "#lab4",
    //data: {
    //    skiftnycklar: 0,
    //    hammare: 0,
    //    såg: 0,

    //},
    //computed: {
    //    adder: function () {
    //        return parseInt(this.skiftnycklar) + parseInt(this.hammare) + parseInt(this.såg)
    //    }
    //},
    //methods: {
    //    AddToSkiftnycklar: function () {
    //        if (this.skiftnycklar  < 0)
    //            return this.skiftnycklar = 0
    //        else 
    //            return this.skiftnycklar++
    //    },
    //    AddTohammare: function () {
    //        if (this.hammare < 0)
    //            return this.hammare = 0
    //        else
    //            return this.hammare++
    //    },
    //    AddTosåg: function () {
    //        if (this.såg < 0)
    //            return this.såg = 0
    //        else
    //            return this.såg++
    //    },
    //    SubFromSkiftnycklar: function () {
    //        if (this.skiftnycklar < 1)
    //            return this.skiftnycklar = 0
    //        else
    //            return this.skiftnycklar--
    //    },
    //    SubFromhammare: function () {
    //        if (this.hammare < 1)
    //            return this.hammare = 0
    //        else
    //            return this.hammare--
    //    },
    //    SubFromsåg: function () {
    //        if (this.såg < 1)
    //            return this.såg = 0
    //        else
    //            return this.såg--
    //    },
    //}





    //el: "#lab3",
    //data: {
    //    myList: [{ name: "Jesper" }, { name: "Malin" }, { name: "Christoffer" },
    //    { name: "Christoffer" }, { name: "Ricky" }],
    //    bå: "",
    //    checked: false,
    //    addName: ""
    //},
    //methods: {
    //    filterListR: function (myList) {

    //        return myList.filter(function (name) {
    //            return name.name[0] == "R"
    //        })
    //    },
    //    filterListM: function (myList) {

    //        return myList.filter(function (name) {
    //            return name.name[0] == "M"
    //        })
    //    }, 
    //    filterList: function () {

    //        let xxx = this.bå;
    //        if (!this.checked) {
    //            return this.myList.filter(function (name) {
    //                return name.name[0].toUpperCase() == xxx.toUpperCase()
    //            });
    //        }
    //        else {
    //            return this.myList.filter(function (name) {
    //                return name.name[0] == xxx
    //            })
    //        }
    //    },
    //    addNames: function () {
    //        this.myList.push({ name: this.addName })
    //    },
    //}


});