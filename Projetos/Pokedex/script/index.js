const baseURL = 'https://pokeapi.co/api/v2/pokemon/';

function generateRandomPokemonID(){
    return Math.floor(Math.random() * 1011);
}

function captlizePokemonName(pokemonName){
    return pokemonName[0].toUpperCase() + pokemonName.substring(1);
}

function getInformationsPokemon(pokemonURL){
let informationPokemon = fetch(pokemonURL)
.then((resp) => resp.json())
.then(function (data) {

    return data;
    
})
.catch(function (error) {
    console.log(error);
    console.log("you've met with a terrible Error, haven't you?");
    
});

return informationPokemon;
}

function createArrayPokemons(){

let arrayPokemonInformations = [];

let pokemonURL = baseURL + generateRandomPokemonID();
let pokemonJson = getInformationsPokemon(pokemonURL);
arrayPokemonInformations.push(pokemonJson);


pokemonURL = baseURL + generateRandomPokemonID();
pokemonJson = getInformationsPokemon(pokemonURL);
arrayPokemonInformations.push(pokemonJson);

return arrayPokemonInformations;
}

function openDetailsPage(pokemonName){
    alert(pokemonName);
}

function populatePokemonCards(){
    
    let pokemonInformations = createArrayPokemons();

    if (pokemonInformations.length === 2){
        var cards = document.getElementsByClassName("pokemon-card");
        for(let pokecard = 0; pokecard < pokemonInformations.length; pokecard++){
            pokemonInformations[pokecard].then(valor => {
                     cards[pokecard].querySelector('.pokemon-card-image').setAttribute('src',valor.sprites.other["official-artwork"].front_default);
        
                    cards[pokecard].querySelector('.pokemon-card-pokedex-number').innerHTML = 'Número: '+ valor.id;
        
                    cards[pokecard].querySelector('.pokemon-name').innerHTML =  captlizePokemonName(valor.name);
                    
                    var divPokemonCardType = cards[pokecard].querySelector('.pokemon-card-types')
        
                    for(let typeCount = 0; typeCount < valor.types.length; typeCount++){
                        var pokemonTypeImg = document.createElement('img')
                        pokemonTypeImg.classList.add('card-type')
                        var pokemonType = valor.types[typeCount].type.name;
                        
                        pokemonTypeImg.src="assets/img/pokemon-type-cards/" + pokemonType + ".png";
                        
                        divPokemonCardType.appendChild(pokemonTypeImg)
                    }

                    cards[pokecard].addEventListener("click", function(){
                        openDetailsPage(valor.name);
                    })
            })
       }
    }   
}

populatePokemonCards()