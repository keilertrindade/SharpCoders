var input = require('fs').readFileSync('2242', 'utf8');
const risada = input.replace(/[^aeiou]/g, '');

if(risada === risada.split('').reverse().join('')){
    console.log('S')
}else{
    console.log('N')
}