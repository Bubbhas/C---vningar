new Vue({
    el: "#newser",
    data: {
        newslist: [],
        addOrCreate: null,
        theNews: null,
        newNews: {},
        stats: null
    },

    methods: {
        async Statistics() {

        },
        async Delete(id) {
            let response = await fetch(`api/News/${id}`, {
                method: "DELETE"
            });

            if (response.status === 200) {

                console.log("Deleten gick bra");

            } else {
                console.log("Unexpected error with the delete", response);
            }
            this.newslist = await this.getAllNews();
        },
        async UpdateNews() {
            let response = await fetch("api/News", {
                method: "PUT",
                body: JSON.stringify({
                    id: this.theNews.id,
                    created: this.theNews.created,
                    header: this.theNews.header,
                    intro: this.theNews.intro,
                    body: this.theNews.body,
                }),
                headers: {
                    "Content-Type": "application/json"
                }
            });
            this.newslist = await this.getAllNews();
        },
        async getAllNews() {
            let response = await fetch("api/news/GetAll")

            if (response.status === 200) {
                    return await response.json();
            }
            else {
                alert("inte bra")
            }
        },

        async recreate() {
            let response = await fetch("api/News/Recreate", {
                method: "POST"
            });

            if (response.status === 200) {
                alert("Allt gick bra")
            } else {
                alert("Något gick fel")
                console.log(response)
            }
        },
        async Seed() {
            let response = await fetch("api/news/GetAll")
            let News = await response.json();
            for (let item of News) {
                let response = await fetch(`api/News/${item.id}`, {
                    method: "DELETE"
                });
            }

            let response2 = await fetch("api/News", {
                method: "POST",
                body: JSON.stringify({
                    header: "FörstaDedfault",
                    intro: "FörstaDedfault",
                    body: "FörstaDedfault",
                }),
                headers: {
                    "Content-Type": "application/json"
                }
            });

            let response3 = await fetch("api/News", {
                method: "POST",
                body: JSON.stringify({
                    header: "AndraDedfault",
                    intro: "AndraDedfault",
                    body: "AndraDedfault",
                }),
                headers: {
                    "Content-Type": "application/json"
                }
            });
            this.newslist = await this.getAllNews();
        },
        async addNews() {
            let response = await fetch("api/News", {
                method: "POST",
                body: JSON.stringify({
                    header: this.newNews.header,
                    intro: this.newNews.intro,
                    body: this.newNews.body,

                }),
                headers: {
                    "Content-Type": "application/json"
                }
            });

            if (response.status === 200) {
                let id = await response.json();
                console.log(`News with id = ${id} added`);

            } else {
                console.log("Unexpected error", await response.text());
            }
            this.newslist = await this.getAllNews();
        },
        async AddNewsField() {
            if (this.addOrCreate === "add")
                this.addOrCreate = null
            else 
            this.addOrCreate = "add"
        },
        async UpdateNewsField(news) {
            if (this.addOrCreate === "create")
                this.addOrCreate = null
            else
                this.addOrCreate = "create"

            this.theNews = news
        },
    },
    created: async function () {
        this.newslist = await this.getAllNews();
    },

})