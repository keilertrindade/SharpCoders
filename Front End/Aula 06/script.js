const body = document.querySelector("#main");

function showSample(msg="", content="", original=""){
    body.innerText += `${msg}:\n`

    if (original != ""){
        body.innerText += `original: ${original}\n`
    }

    body.innerText += `sample: ${content}\n\n`
}

let dicionario = new Map()
dicionario.set("cachorro", "animal")
dicionario.set("felicidade", "emoção")
dicionario.set("porta", "objeto")

//body.innerText += dicionario.get("cachorro")

dicionario.forEach((key, value) => {
    body.innerText += `key(${value}) : value(${key})\n`
})

const pessoa = new Map();
pessoa.set("joao", "nome");
pessoa.set({
    "rua":"rua X","numero": 12},"endereco");
pessoa.set(25, "idade")

let skills = new Set();

skills.add("C#")
skills.add("Javascript")
skills.add("C#")
skills.add("C#")