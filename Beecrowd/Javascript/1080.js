var input = require('fs').readFileSync('1080', 'utf8');
var lines = input.split('\n').map(Number);

let posicao = 0;
let valor = lines[0];

for (let i = 0; i < 100; i++){
    if(lines[i] > valor){
        posicao = i;
        valor = lines[i];
    }
}

console.log(valor);
console.log(posicao+1);