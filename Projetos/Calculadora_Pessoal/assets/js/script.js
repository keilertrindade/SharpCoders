const calculadora = document.getElementById("calculator-buttons");
const buttons = document.getElementsByTagName("button");

/*Array.from(buttons).forEach(button =>
    button.addEventListener("click", showNumber)); */

calculadora.addEventListener("click", showNumber);

