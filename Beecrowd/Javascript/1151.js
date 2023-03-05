var input = require('fs').readFileSync('1151', 'utf8');
var numero = parseInt(input);

var vetor = [0,1];


for(let cont = 2; cont < numero; cont++){
    vetor[cont] = vetor[cont-2] + vetor[cont-1];
}


console.log(vetor.join(" "));