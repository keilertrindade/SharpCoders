const baseURL = 'https://pokeapi.co/api/v2/pokemon/';

function generateRandomPokemonID(){
    return Math.floor(Math.random() * 1011);
}

function getInformationsPokemon(pokemonURL){
let informationPokemon = fetch(pokemonURL)
.then((resp) => resp.json())
.then(function (data) {
    
    //console.log(data);
    return data;
    
})
.catch(function (error) {
    console.log(error);
    console.log("you've met with a terrible Error, haven't you?");
    
});

return informationPokemon;
}

function populatePokemonCard(pokemonInformations, cardId){
    pokemonInformations.then(valor => {
        var pokemoncard = document.getElementById(cardId);
        //pokemoncard.children[0].setAttribute('src',valor.sprites.other.home.front_default)
        
        pokemoncard.children[1].children[0].innerHTML = valor.name.toUpperCase();
        pokemoncard.children[1].children[1].innerHTML = 'Nº: '+ valor.id;

            
        console.log(pokemoncard.children[1].children[1]);
        //console.log(valor.sprites.other.home.front_default)

    })
    




}


const pokemonURL = baseURL + generateRandomPokemonID();

let pokemon = getInformationsPokemon(pokemonURL)


populatePokemonCard(pokemon, 'pokemon-card-1')
