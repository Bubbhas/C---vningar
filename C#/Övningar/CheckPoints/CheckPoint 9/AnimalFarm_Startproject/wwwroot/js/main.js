const app = new Vue({
    el: "#checkpoint",
    data: {

        allanimals: [],
        newAnimal: [],
    },
    created: async function () {
        this.allanimals = await this.getAllAnimals();
    },
    methods: {
        addOnePanda: function (p) {
            allanimals.push(p)
        },
        async getAllAnimals() {
            let response = await fetch("animals/GetAll")

            if (response.status === 200) {
                return await response.json();
            }
            else {
                alert("inte bra")
            }
        },
        async addAnimals(p) {
            let response = await fetch("animals", {
                method: "POST",
                body: JSON.stringify({
                    name: p,

                }),
                headers: {
                    "Content-Type": "application/json"
                }
            });
            if (response.status === 200) {
             
                console.log(`Animal  added`);

            } else {
                console.log("Unexpected error", await response.text());
            }
            this.allanimals = await this.getAllAnimals();
        },

    },
});