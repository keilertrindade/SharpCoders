var input = require('fs').readFileSync('1272', 'utf8');
var lines = input.trim().split("\n");


var casosTeste = parseInt(lines[0]);
//console.log(lines)

for (let i = 1; i <= casosTeste; i++) {
    const mensagem = lines[i].split(' ').reduce((acumulador, atual) => acumulador + atual.charAt(0), '');
    console.log(mensagem);

}