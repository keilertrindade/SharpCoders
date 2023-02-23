
        //linter: eslint, commitlint
        //Document Object Model
        //webpack
        //ruthy and falsy values
        //truthy != 0, "aaa"
        //falsy: null, undefined, [], "", NaN(Not a Number)


        console.log('Hello World');
        document.getElementById('title').innerText = "Meu hello world!";

        let x = {
            nome: 'João',
            idade: 20,
            altura: 1.80,
            
            dizerOi(nome){
                console.log(`Olá ${nome}, muito prazer, eu sou o ${x.nome}!`)
            }
        }

        let autorizado = (x.idade >= 18) ? "ok" : "not";
        //function

        let soma = (a, b) => a + b;




