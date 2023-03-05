var input = require('fs').readFileSync('1132', 'utf8');
var [x,y] = input.split('\n').map(Number);

let resultado = 0;

for(let valor = Math.min(x,y); valor <= Math.max(x,y); valor++){
    if(valor % 13 !== 0)
        resultado += valor;   
}

console.log(resultado);