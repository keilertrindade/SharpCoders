var input = require('fs').readFileSync('1072', 'utf8');
var lines = input.split('\n');

var valores = lines.map(Number);
var casos = valores.shift();
var intervalo = [10, 20];

let valoresIn = 0, valoresOut = 0;

for (let index = 0; index < casos; index++){
    if(valores[index] >= intervalo[0] && valores[index] <= intervalo[1]){
        valoresIn++;
    }else{
        valoresOut++;
    }

}

console.log(valoresIn + " in");
console.log(valoresOut + " out");