const baseURL = 'https://pokeapi.co/api/v2/pokemon/';

function generateRandomPokemonID(){
    return Math.floor(Math.random() * 1011);
}

function captlizeName(name){

    if(name.includes("-")){
        let index = name.search("-")
        return name[0].toUpperCase() + name.substring(1,index+1) + captlizeName(name.substring(index+1));
    }

    return name[0].toUpperCase() + name.substring(1);
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

function openDetailsPage(pokemonId){
    
    window.open("pokecard.html?pokemon=" + pokemonId);
}

function populatePokemonCards(){
    
    let pokemonInformations = createArrayPokemons();

    if (pokemonInformations.length === 2){
        var cards = document.getElementsByClassName("pokemon-card");
        for(let pokecard = 0; pokecard < pokemonInformations.length; pokecard++){
            pokemonInformations[pokecard].then(valor => {
                    cards[pokecard].querySelector('.pokemon-card-image').setAttribute('src',valor.sprites.other["official-artwork"].front_default);
        
                    cards[pokecard].querySelector('.pokemon-card-pokedex-number').innerHTML = 'Número: '+ valor.id;
        
                    cards[pokecard].querySelector('.pokemon-name').innerHTML =  captlizeName(valor.name);
                    
                    var divPokemonCardType = cards[pokecard].querySelector('.pokemon-card-types')
        
                    for(let typeCount = 0; typeCount < valor.types.length; typeCount++){
                        var pokemonTypeImg = document.createElement('img')
                        pokemonTypeImg.classList.add('card-type')
                        var pokemonType = valor.types[typeCount].type.name;
                        
                        pokemonTypeImg.src="assets/img/pokemon-type-cards/" + pokemonType + ".png";
                        
                        divPokemonCardType.appendChild(pokemonTypeImg)
                    }

                    cards[pokecard].addEventListener("click", function(){
                        openDetailsPage(valor.id);
                    })
            })
       }
    }   
}

function addingButtonFunctions(){
    let surpriseButton = document.querySelector('#surprise-me-button');
    let searchPokemonButton = document.querySelector('#search-pokemon-button');
    let searchPokemonInput = document.querySelector('#input-search-pokemon');
    surpriseButton.addEventListener("click", function(){
        openDetailsPage(generateRandomPokemonID()); 
    })

    searchPokemonButton.addEventListener("click", function(event){
        let pokemonName = document.querySelector('#input-search-pokemon').value.trim().toLowerCase();
        openDetailsPage(pokemonName);
        searchPokemonInput.value = "";
    })
   
    searchPokemonInput.addEventListener("keyup", function(event){
        if(event.keyCode === 13){
            searchPokemonButton.click();
        }
    })

}



populatePokemonCards()
addingButtonFunctions()