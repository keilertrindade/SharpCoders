var input = require('fs').readFileSync('1144', 'utf8');
var valor = parseInt(input);

for (let i = 1; i <= valor; i++){
        console.log(`${i} ${Math.pow(i, 2)} ${Math.pow(i, 3)}`);
        console.log(`${i} ${Math.pow(i, 2) + 1} ${Math.pow(i, 3) + 1}`);   
}