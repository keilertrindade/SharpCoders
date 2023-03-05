var input = require('fs').readFileSync('1042', 'utf8');
var lines = input.split(' ');
var numeros = lines.map(Number);
var numerosOrder = lines.map(Number);

numerosOrder.sort((a,b) => a - b);
numerosOrder.forEach(element => console.log(element));

console.log();

numeros.forEach(element => console.log(element));
