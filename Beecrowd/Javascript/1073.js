var input = require('fs').readFileSync('1073', 'utf8');
var valor = parseInt(input);

for (let numero = 2; numero <= valor; numero += 2){
    console.log(`${numero}^2 = ${numero*numero}`);
}